using System;
using System.Collections.Generic;
using System.Text;

namespace AiProStore.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
