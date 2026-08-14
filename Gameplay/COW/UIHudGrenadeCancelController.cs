using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200276C")]
internal class UIHudGrenadeCancelController : UIHudButtonBaseController
{
	[Token(Token = "0x400F372")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudCancelView m_View;

	[Token(Token = "0x400F373")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_pos;

	[Token(Token = "0x400F374")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_Offset;

	[Token(Token = "0x600F12A")]
	[Address(RVA = "0x133370C", Offset = "0x133370C", VA = "0x133370C")]
	public UIHudGrenadeCancelController()
	{
	}

	[Token(Token = "0x600F12B")]
	[Address(RVA = "0x133376C", Offset = "0x133376C", VA = "0x133376C")]
	public Vector3 GetOffset()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F12C")]
	[Address(RVA = "0x1333AD8", Offset = "0x1333AD8", VA = "0x1333AD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F12D")]
	[Address(RVA = "0x1333B7C", Offset = "0x1333B7C", VA = "0x1333B7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F12E")]
	[Address(RVA = "0x1333DB4", Offset = "0x1333DB4", VA = "0x1333DB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F12F")]
	[Address(RVA = "0x1333F50", Offset = "0x1333F50", VA = "0x1333F50")]
	private void OnChangeVisible(object[] param)
	{
	}

	[Token(Token = "0x600F130")]
	[Address(RVA = "0x1334128", Offset = "0x1334128", VA = "0x1334128")]
	private void OnDragUseIceWall(object[] param)
	{
	}

	[Token(Token = "0x600F131")]
	[Address(RVA = "0x1333934", Offset = "0x1333934", VA = "0x1333934")]
	public bool WeaponOnHandIsIceWall()
	{
		return default(bool);
	}

	[Token(Token = "0x600F132")]
	[Address(RVA = "0x1334230", Offset = "0x1334230", VA = "0x1334230", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600F133")]
	[Address(RVA = "0x13342D4", Offset = "0x13342D4", VA = "0x13342D4")]
	public void SetDefaultPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600F134")]
	[Address(RVA = "0x133435C", Offset = "0x133435C", VA = "0x133435C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F135")]
	[Address(RVA = "0x1334364", Offset = "0x1334364", VA = "0x1334364")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
