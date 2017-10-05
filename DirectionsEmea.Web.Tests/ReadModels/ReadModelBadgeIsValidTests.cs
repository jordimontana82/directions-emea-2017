using DirectionsEmea.Web.ReadModels;
using FakeXrmEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TypedEntities;

namespace DirectionsEmea.Web.Tests.ReadModels
{
    public class ReadModelBadgeIsValidTests
    {
        [Fact]
        public void When_there_are_no_contacts_with_the_badge_id_badge_is_not_valid()
        {
            Assert.True(false);
        }

        [Fact]
        public void When_there_are_is_a_matching_contact_badge_is_valid()
        {
            Assert.True(false);
        }
    }
}
