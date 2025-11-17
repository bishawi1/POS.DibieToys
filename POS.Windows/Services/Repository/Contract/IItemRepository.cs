using POS.Shared.Models;
using POS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Windows.Services.Repository.Contract
{
    public interface IItemRepository
    {
        public DataTable GetItemGroup(int parentItemGroupId);

        public bool AddItem(AddItemRequestModel model);
        public DataTable GetItemUnitList(ItemListCriteriaViewModel criteria);

    }
}
