using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using RazorPagesIgnis.Pages;
using RazorPagesIgnis.Data;
using Moq;
using RazorPagesIgnis.Tests;

namespace RazorPagesIgnis.Test
{
    public class IndexPageTests
    {
        [Fact]
    public async Task DeleteMessageAsync_MessageIsDeleted_WhenMessageIsFound()
    {
        using (var db = new AppDbContext(Utilities.TestDbContextOptions()))
        {
            // Arrange
            var seedMessages = AppDbContext.GetSeedingMessages();
            await db.AddRangeAsync(seedMessages);
            await db.SaveChangesAsync();
            var recId = 1;
            var expectedMessages = 
                seedMessages.Where(message => message.Id != recId).ToList();

            // Act
            await db.DeleteMessageAsync(recId);

            // Assert
            var actualMessages = await db.Messages.AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedMessages.OrderBy(m => m.Id).Select(m => m.Text), 
                actualMessages.OrderBy(m => m.Id).Select(m => m.Text));
        }
    }
  }
}