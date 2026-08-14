using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C96")]
public class ItemFunctionAttributeBaseConfig : ScriptableObject
{
	[Token(Token = "0x6006032")]
	[Address(RVA = "0x3111C04", Offset = "0x3111C04", VA = "0x3111C04")]
	public ItemFunctionAttributeBaseConfig()
	{
	}

	[Token(Token = "0x6006033")]
	[Address(RVA = "0x3111C0C", Offset = "0x3111C0C", VA = "0x3111C0C", Slot = "4")]
	public virtual List<ItemFunctionUIData> GetUIData(SceneEditObjectAttrBase obj)
	{
		return null;
	}
}
