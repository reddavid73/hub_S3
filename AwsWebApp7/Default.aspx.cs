using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;
using System.IO;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace AwsWebApp7
{
    public partial class _Default : System.Web.UI.Page
    {
        protected IAmazonS3 s3;

        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(1024);


            sb = new StringBuilder(1024);
            using (StringWriter sr = new StringWriter(sb))
            {
                try
                {
                    s3 = new AmazonS3Client();
                    this.WriteS3Info();
                }
                catch (AmazonS3Exception ex)
                {
                    if (ex.ErrorCode != null && (ex.ErrorCode.Equals("InvalidAccessKeyId") ||
                        ex.ErrorCode.Equals("InvalidSecurity")))
                    {
                        sr.WriteLine("The account you are using is not signed up for Amazon S3");
                        sr.WriteLine("<br />");
                        sr.WriteLine("You can sign up for Amazon S3 at http://aws.amazon.com/s3");
                        sr.WriteLine("<br />");
                        sr.WriteLine("<br />");
                    }
                    else
                    {
                        sr.WriteLine("Caught Exception: " + ex.Message);
                        sr.WriteLine("<br />");
                        sr.WriteLine("Response Status Code: " + ex.StatusCode);
                        sr.WriteLine("<br />");
                        sr.WriteLine("Error Code: " + ex.ErrorCode);
                        sr.WriteLine("<br />");
                        sr.WriteLine("Request ID: " + ex.RequestId);
                        sr.WriteLine("<br />");
                        sr.WriteLine("<br />");
                    }
                    this.s3Placeholder.Text = sr.ToString();
                }
            }

        }



        private void WriteS3Info()
        {
            ////StringBuilder output = new StringBuilder();
            //ListBucketsResponse response = s3.ListBuckets();
            //if (response.Buckets != null && response.Buckets.Count > 0)
            //    foreach (S3Bucket theBucket in response.Buckets)
            //    {
            //        output.AppendFormat("<li>{0}</li>", theBucket.BucketName);
            //    }
            //this.s3Placeholder.Text = output.ToString();


            StringBuilder output = new StringBuilder();
            using (AmazonS3Client client = new AmazonS3Client())
            {

                try
                {
                    ListObjectsRequest listObjectsRequest = new ListObjectsRequest();
                    listObjectsRequest.BucketName = "coll-cam-s3";

                    listObjectsRequest.Prefix = "lynfa/send_prodotti";

                    ListObjectsResponse listObjectsResponse = client.ListObjects(listObjectsRequest);
                    foreach (S3Object entry in listObjectsResponse.S3Objects)
                    {

                        //Console.WriteLine("Found object with key {0}, size {1}, last modification date {2}", entry.Key, entry.Size, entry.LastModified);
                        output.AppendFormat("Found object with key {0}, size {1}, last modification date {2}", entry.Key, entry.Size, entry.LastModified);
                    }
                    this.s3Placeholder.Text = output.ToString();
                }
                catch (AmazonS3Exception e)
                {

                }

            }







        }


    }
}