using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_checkbox.Pages
{
    public class RazorCheckBoxWithModelModel : PageModel
    {
        public List<CheckboxItem2> CheckboxItems { get; set; }

        [BindProperty]
        public List<string> SelectedItems { get; set; }
        public void OnGet()
        {
            LoadCheckboxItems();
        }
        public void OnPost()
        {

            LoadCheckboxItems();
            foreach (var item in CheckboxItems)
            {
                item.IsChecked = SelectedItems?.Contains(item.Value) ?? false;
            }
            if (SelectedItems != null)
            {

                ViewData["SelectedItems"] = SelectedItems;

            }
        }
        private void LoadCheckboxItems()
        {
            CheckboxItems = new List<CheckboxItem2>
            {
                new CheckboxItem2 { Value = "1", Text = "Option 1" },
                new CheckboxItem2 { Value = "2", Text = "Option 2" },
                new CheckboxItem2 { Value = "3", Text = "Option 3" }
            };
        }
    }

    public class CheckboxItem2
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get; set; }
    }
}
