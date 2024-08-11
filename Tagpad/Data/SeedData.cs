using Tagpad.Models;

namespace Tagpad.Data
{
    public static class SeedData
    {
        public static void Initialize(NoteContext context)
        {

            // Check if there are already records in the database
            if (context.Notes.Any())
            {
                return; // DB has been seeded
            }

            // Seed data
            context.Notes.Add(new Note
            {
                //ID = 1,
                Title = "Getting Started with TagPad",
                Content = "Welcome to TagPad!\r\n\r\nHere’s a quick guide to get you started:\r\n\r\n1. Creating a Note: \r\n   - Click on the 'New Note' button to create a new note.\r\n   - Enter a title and some content. You can use this space to jot down anything you need!\r\n\r\n2. Tagging Your Notes:\r\n   - You can add tags to your notes to help organize and find them easily.\r\n   - Tags are like labels that you can assign to your notes. For example, you might use tags like 'Work', 'Personal', or 'Important'.\r\n\r\n3. Searching for Notes:\r\n   - Use the search bar to find notes by title or by tags.\r\n   - Simply type in keywords or tag names to filter your notes.\r\n\r\n4. Editing and Deleting Notes:\r\n   - You can edit or delete any note by selecting the appropriate option from the note’s menu.\r\n\r\n5. Tips:\r\n   - Keep your notes organized by using relevant tags.\r\n   - Regularly review and update your notes to keep track of your tasks and ideas.\r\n\r\nEnjoy using TagPad! Feel free to explore and make it your own.\r\n\r\nHappy Note-Taking!\r\n",
                DateCreated=DateTime.Now,
                DateUpdated=DateTime.Now,
            }
            );

            context.SaveChanges();
        }
    }

}
