using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Variant_1.View;
namespace Variant_1
{
    public class Pages
    {
        private static List<KeyValuePair<PagesEnum, Page>> pages = new List<KeyValuePair<PagesEnum, Page>>()
        {
            new KeyValuePair<PagesEnum, Page>(PagesEnum.mean_arephmetic, new MeanArephmeticPage()),
            new KeyValuePair<PagesEnum, Page>(PagesEnum.work_with_files, new WorkWithFilesPage()),
            new KeyValuePair<PagesEnum, Page>(PagesEnum.quadratic_equation, new QuadraticEquationPage()),
            new KeyValuePair<PagesEnum, Page>(PagesEnum.work_with_lists, new WorkWithListsPage()),
        };

        private KeyValuePair<PagesEnum, Page>? getPagePair(string page)
        {
            foreach (var pair in pages)
            {
                if (page == pair.Key.ToString())
                {
                    return pair;
                }
            }
            return null;
        }

        public Page select(Enum page)
        {
            return getPagePair(page.ToString())?.Value;
        }

        public Page select(string page)
        {
            return getPagePair(page)?.Value;
        }

    }
}