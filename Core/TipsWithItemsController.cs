using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20023CF")]
public class TipsWithItemsController : UIPopupWindowController
{
	[Token(Token = "0x400DEAD")]
	[FieldOffset(Offset = "0x48")]
	private TipsWithItemsView m_View;

	[Token(Token = "0x400DEAE")]
	[FieldOffset(Offset = "0x4C")]
	private int m_PaddingY;

	[Token(Token = "0x600C9F3")]
	[Address(RVA = "0x2639C98", Offset = "0x2639C98", VA = "0x2639C98")]
	public TipsWithItemsController()
	{
	}

	[Token(Token = "0x600C9F4")]
	[Address(RVA = "0x2639CA8", Offset = "0x2639CA8", VA = "0x2639CA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9F5")]
	[Address(RVA = "0x2639D0C", Offset = "0x2639D0C", VA = "0x2639D0C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9F6")]
	[Address(RVA = "0x2639E14", Offset = "0x2639E14", VA = "0x2639E14", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C9F7")]
	[Address(RVA = "0x2639F00", Offset = "0x2639F00", VA = "0x2639F00")]
	public void SetData(Vector3 itemCenter, Vector3 offset, List<TipsWithItemsItemVO> dataList)
	{
	}

	[Token(Token = "0x600C9F8")]
	[Address(RVA = "0x263ADF0", Offset = "0x263ADF0", VA = "0x263ADF0")]
	private void OnClickClose(object[] args)
	{
	}
}
