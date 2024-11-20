using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_checkbox.Pages
{
    public class PageCheckboxModel : PageModel
    {
        public List<CheckboxItem> CheckboxItems { get; set; }

        [BindProperty]
        public List<string> SelectedItems { get; set; }
        public void OnGet()
        {
            CheckboxItems = new List<CheckboxItem>
            {
                new CheckboxItem { Value = "1", Text = "Option 1" },
                new CheckboxItem { Value = "2", Text = "Option 2" },
                new CheckboxItem { Value = "3", Text = "Option 3" }
            };
        }
        public void OnPost()
        {
            CheckboxItems = new List<CheckboxItem>
            {
                new CheckboxItem { Value = "1", Text = "Option 1" },
                new CheckboxItem { Value = "2", Text = "Option 2" },
                new CheckboxItem { Value = "3", Text = "Option 3" }
            };
             foreach (var item in CheckboxItems)
            {
                item.IsChecked = SelectedItems?.Contains(item.Value) ?? false;
            }
            if (SelectedItems != null)
            {

                ViewData["SelectedItems"] = SelectedItems;

            }
        }
    }

    public class CheckboxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
         public bool IsChecked { get; set; }
    }
}
