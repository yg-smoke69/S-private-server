using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003610")]
public class UIHudClothItemView : MonoBehaviour
{
	[Token(Token = "0x4015A23")]
	[FieldOffset(Offset = "0xC")]
	public UILabel itemID;

	[Token(Token = "0x4015A24")]
	[FieldOffset(Offset = "0x10")]
	public UILabel itemName;

	[Token(Token = "0x4015A25")]
	[FieldOffset(Offset = "0x14")]
	public UIButton clickButton;

	[Token(Token = "0x4015A26")]
	[FieldOffset(Offset = "0x18")]
	private uint itemid;

	[Token(Token = "0x60165DE")]
	[Address(RVA = "0x14856D8", Offset = "0x14856D8", VA = "0x14856D8")]
	public UIHudClothItemView()
	{
	}

	[Token(Token = "0x60165DF")]
	[Address(RVA = "0x14856E0", Offset = "0x14856E0", VA = "0x14856E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60165E0")]
	[Address(RVA = "0x14857B8", Offset = "0x14857B8", VA = "0x14857B8")]
	public void SetData(InventoryClothInfo clothinfo)
	{
	}

	[Token(Token = "0x60165E1")]
	[Address(RVA = "0x1485920", Offset = "0x1485920", VA = "0x1485920")]
	private void OnClickItem()
	{
	}
}
