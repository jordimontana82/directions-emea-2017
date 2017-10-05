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
    public class ReadModelCheckContactDidntVoteTests
    {
        [Fact]
        public void When_there_are_no_vote_records_against_the_contact_then_is_valid()
        {
            Assert.True(false);
        }
        
        [Fact]
        public void When_there_is_at_least_one_vote_against_the_contact_then_is_NOT_valid()
        {
            Assert.True(false);
        }
    }
}
