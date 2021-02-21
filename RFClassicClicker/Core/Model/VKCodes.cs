using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RFClassicClicker.Core.Model
{
    class VKCodes
    {
        public const uint VK_KEY_F1 = 0x70;
        public const uint VK_KEY_F2 = 0x71;
        public const uint VK_KEY_F3 = 0x72;
        public const uint VK_KEY_F4 = 0x73;
        public const uint VK_KEY_F5 = 0x74;
        public const uint VK_KEY_F6 = 0x75;
        public const uint VK_KEY_F7 = 0x76;
        public const uint VK_KEY_F8 = 0x77;
        public const uint VK_KEY_F9 = 0x78;
        public const uint VK_KEY_F10 = 0x79;
        public const uint VK_KEY_F11 = 0x7A;
        public const uint VK_KEY_F12 = 0x7B;

        public Dictionary<string, uint> KeysFDictionary { get; set; }

        public VKCodes()
        {
            KeysFDictionary = new Dictionary<string, uint>();

            FieldInfo[] fieldInfos = GetType().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (FieldInfo fi in fieldInfos)
            {
                uint value = (uint) fi.GetValue(fi);
                string keyName = fi.Name.Split('_', StringSplitOptions.RemoveEmptyEntries).Last();

                KeysFDictionary.Add(keyName, value);
            }
        }
    }
}
