﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Element;
using System.Threading.Tasks;

namespace Element.Demo.MessageBox
{
    public partial class BasicMessageBox : ComponentBase
    {
        [Inject]
        MessageService MessageService { get; set; }
        [Inject]
        Element.MessageBox MessageBox { get; set; }
        public async Task ShowMessageAsync()
        {
            var result = await MessageBox.AlertAsync("测试消息");
            MessageService.Show(result.ToString());
        }
    }
}
