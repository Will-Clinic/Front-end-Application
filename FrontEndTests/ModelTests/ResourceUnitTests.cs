using System;
using System.Collections.Generic;
using System.Text;
using WAWillClinicFrontEnd.Models;
using Xunit;

namespace FrontEndTests.ModelTests
{
    public class ResourceUnitTests
    {
        [Fact]
        public void CanGetID()
        {
            Resource resource = new Resource
            {
                ID = 1,
            };

            int expected = 1;
            int actual = resource.ID;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetID()
        {
            Resource resource = new Resource
            {
                ID = 1,
            };

            resource.ID = 42;

            int expected = 42;
            int actual = resource.ID;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetTitle()
        {
            Resource resource = new Resource
            {
                Title = "Test Resource",
            };

            string expected = "Test Resource";
            string actual = resource.Title;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetTitle()
        {
            Resource resource = new Resource
            {
                Title = "Test Resource",
            };

            resource.Title = "New Resource";

            string expected = "New Resource";
            string actual = resource.Title;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetLink()
        {
            Resource resource = new Resource
            {
                Link = "https://github.com/",
            };

            string expected = "https://github.com/";
            string actual = resource.Link;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetLink()
        {
            Resource resource = new Resource
            {
                Link = "https://github.com/",
            };

            resource.Link = "https://www.google.com/";

            string expected = "https://www.google.com/";
            string actual = resource.Link;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetImageUrl()
        {
            Resource resource = new Resource
            {
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/6/66/An_up-close_picture_of_a_curious_male_domestic_shorthair_tabby_cat.jpg",
            };

            string expected = "https://upload.wikimedia.org/wikipedia/commons/6/66/An_up-close_picture_of_a_curious_male_domestic_shorthair_tabby_cat.jpg";
            string actual = resource.ImageURL;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetImageUrl()
        {
            Resource resource = new Resource
            {
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/6/66/An_up-close_picture_of_a_curious_male_domestic_shorthair_tabby_cat.jpg",
            };

            resource.ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXk7s5SVnpDOjU-zqn4W7_FVGZeIrOiKlCeosU4w_Td5JN-NX9";

            string expected = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXk7s5SVnpDOjU-zqn4W7_FVGZeIrOiKlCeosU4w_Td5JN-NX9";
            string actual = resource.ImageURL;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetDescription()
        {
            Resource resource = new Resource
            {
                Description = "The test resource is very useful.",
            };

            string expected = "The test resource is very useful.";
            string actual = resource.Description;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetDescription()
        {
            Resource resource = new Resource
            {
                Description = "The test resource is very useful.",
            };

            resource.Description = "Changed description for helpful resource.";

            string expected = "Changed description for helpful resource.";
            string actual = resource.Description;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanGetType()
        {
            Resource resource = new Resource
            {
                Type = ResourceType.Family,
            };

            string expected = Convert.ToString(ResourceType.Family);
            string actual = Convert.ToString(resource.Type);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSetType()
        {
            Resource resource = new Resource
            {
                Type = ResourceType.Family,
            };

            resource.Type = ResourceType.HealthCare;

            string expected = Convert.ToString(ResourceType.HealthCare);
            string actual = Convert.ToString(resource.Type);

            Assert.Equal(expected, actual);
        }
    }
}
