using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_tests_white
{
    [TestFixture]
    public class GroupRemoveTests : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (oldGroups.Count <= 1)
            {
                GroupData newGroup = new GroupData() {Name = "deleteme"};
                app.Groups.Add(newGroup); 
                oldGroups.Add(newGroup);
            }

            app.Groups.Remove(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Sort();
            oldGroups.RemoveAt(0);
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}