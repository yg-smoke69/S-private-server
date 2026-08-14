using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002AFE")]
public class UIRoomPopMenuController : UIPopupWindowController
{
	[Token(Token = "0x40107E6")]
	[FieldOffset(Offset = "0x48")]
	private RoomPlayerInfo m_info;

	[Token(Token = "0x40107E7")]
	[FieldOffset(Offset = "0x4C")]
	private int CellWidth;

	[Token(Token = "0x40107E8")]
	[FieldOffset(Offset = "0x50")]
	private int CellHeight;

	[Token(Token = "0x40107E9")]
	[FieldOffset(Offset = "0x54")]
	private int CellWidthPadding;

	[Token(Token = "0x40107EA")]
	[FieldOffset(Offset = "0x58")]
	private int m_NewCellWidth;

	[Token(Token = "0x40107EB")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 m_showOffset;

	[Token(Token = "0x40107EC")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 m_clickPos;

	[Token(Token = "0x40107ED")]
	[FieldOffset(Offset = "0x6C")]
	private int m_offset;

	[Token(Token = "0x40107EE")]
	[FieldOffset(Offset = "0x70")]
	private int m_activatedMenuWidth;

	[Token(Token = "0x40107EF")]
	[FieldOffset(Offset = "0x74")]
	private int m_activatedMenuHeight;

	[Token(Token = "0x40107F0")]
	[FieldOffset(Offset = "0x78")]
	private float m_scale;

	[Token(Token = "0x40107F1")]
	[FieldOffset(Offset = "0x7C")]
	private UIRoomPopMenuView m_View;

	[Token(Token = "0x40107F2")]
	[FieldOffset(Offset = "0x80")]
	private List<UICommonPopMenuItemController> m_ItemControllerList;

	[Token(Token = "0x6011A6E")]
	[Address(RVA = "0x2BE66C8", Offset = "0x2BE66C8", VA = "0x2BE66C8")]
	public UIRoomPopMenuController()
	{
	}

	[Token(Token = "0x6011A6F")]
	[Address(RVA = "0x2BE6774", Offset = "0x2BE6774", VA = "0x2BE6774")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A70")]
	[Address(RVA = "0x2BE6818", Offset = "0x2BE6818", VA = "0x2BE6818", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011A71")]
	[Address(RVA = "0x2BE6870", Offset = "0x2BE6870", VA = "0x2BE6870", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A72")]
	[Address(RVA = "0x2BE6B34", Offset = "0x2BE6B34", VA = "0x2BE6B34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011A73")]
	[Address(RVA = "0x2BE6C68", Offset = "0x2BE6C68", VA = "0x2BE6C68")]
	public void UpdateMenuData(RoomPlayerInfo info, [Optional] List<CommonPopMenuData> list)
	{
	}

	[Token(Token = "0x6011A74")]
	[Address(RVA = "0x2BE75B0", Offset = "0x2BE75B0", VA = "0x2BE75B0")]
	private void ResizeMenuWidth()
	{
	}

	[Token(Token = "0x6011A75")]
	[Address(RVA = "0x2BE792C", Offset = "0x2BE792C", VA = "0x2BE792C")]
	private void ComputePopPosition(int itemNum)
	{
	}

	[Token(Token = "0x6011A76")]
	[Address(RVA = "0x2BE7CB8", Offset = "0x2BE7CB8", VA = "0x2BE7CB8")]
	private void OnAddFriend()
	{
	}

	[Token(Token = "0x6011A77")]
	[Address(RVA = "0x2BE7EB0", Offset = "0x2BE7EB0", VA = "0x2BE7EB0")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x6011A78")]
	[Address(RVA = "0x2BE7F14", Offset = "0x2BE7F14", VA = "0x2BE7F14")]
	private void OnClickeMenuItem(object[] data)
	{
	}

	[Token(Token = "0x6011A79")]
	[Address(RVA = "0x2BE7F80", Offset = "0x2BE7F80", VA = "0x2BE7F80")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011A7A")]
	[Address(RVA = "0x2BE7F88", Offset = "0x2BE7F88", VA = "0x2BE7F88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011A7B")]
	[Address(RVA = "0x2BE7F90", Offset = "0x2BE7F90", VA = "0x2BE7F90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
