﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JavierSuarez : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://javiersuarezruiz.wordpress.com/feed/"); }
        }

        public string FirstName => "Javier";
        public string LastName => "Suarez";
        public string StateOrRegion => "Seville, Spain";
        public string EmailAddress => "javiersuarezruiz@hotmail.com";
        public string ShortBioOrTagLine => "is a passionate software developer from Spain who enjoys learning, talk and help others";
        public Uri WebSite => new Uri("http://javiersuarezruiz.wordpress.com");
        public string TwitterHandle => "jsuarezruiz";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(37.3890920, -5.9844590);
        public string GitHubHandle => "jsuarezruiz";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}