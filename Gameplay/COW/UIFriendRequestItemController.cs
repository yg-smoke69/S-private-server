using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002627")]
public class UIFriendRequestItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400EBAC")]
	[FieldOffset(Offset = "0x38")]
	private UIFriendRequestItemView m_View;

	[Token(Token = "0x400EBAD")]
	[FieldOffset(Offset = "0x3C")]
	private FriendAccountInfo m_Data;

	[Token(Token = "0x400EBAE")]
	[FieldOffset(Offset = "0x40")]
	private UIDragScrollView m_DragComponent;

	[Token(Token = "0x400EBAF")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_ItemCollider;

	[Token(Token = "0x400EBB0")]
	[FieldOffset(Offset = "0x48")]
	private EFriendTabType tabType;

	[Token(Token = "0x400EBB1")]
	[FieldOffset(Offset = "0x4C")]
	private UIBaseProfileInfoController m_BaseProfile;

	[Token(Token = "0x17001170")]
	public UIDragScrollView DragComponent
	{
		[Token(Token = "0x600E284")]
		[Address(RVA = "0x2510EFC", Offset = "0x2510EFC", VA = "0x2510EFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001171")]
	public Vector2 ItemViewSize
	{
		[Token(Token = "0x600E286")]
		[Address(RVA = "0x251109C", Offset = "0x251109C", VA = "0x251109C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x600E283")]
	[Address(RVA = "0x2510EF4", Offset = "0x2510EF4", VA = "0x2510EF4")]
	public UIFriendRequestItemController()
	{
	}

	[Token(Token = "0x600E285")]
	[Address(RVA = "0x2510FF8", Offset = "0x2510FF8", VA = "0x2510FF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E287")]
	[Address(RVA = "0x25112A4", Offset = "0x25112A4", VA = "0x25112A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E288")]
	[Address(RVA = "0x2511718", Offset = "0x2511718", VA = "0x2511718", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E289")]
	[Address(RVA = "0x2511788", Offset = "0x2511788", VA = "0x2511788", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E28A")]
	[Address(RVA = "0x25118B8", Offset = "0x25118B8", VA = "0x25118B8", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600E28B")]
	[Address(RVA = "0x2511B48", Offset = "0x2511B48", VA = "0x2511B48")]
	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	[Token(Token = "0x600E28C")]
	[Address(RVA = "0x2511E54", Offset = "0x2511E54", VA = "0x2511E54")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600E28D")]
	[Address(RVA = "0x2511EE4", Offset = "0x2511EE4", VA = "0x2511EE4")]
	private void OnRefuseBtnClick()
	{
	}

	[Token(Token = "0x600E28E")]
	[Address(RVA = "0x2512080", Offset = "0x2512080", VA = "0x2512080")]
	private void OnBlockBtnClick()
	{
	}

	[Token(Token = "0x600E28F")]
	[Address(RVA = "0x25125D4", Offset = "0x25125D4", VA = "0x25125D4")]
	private void OnCancelBlockBtnClick()
	{
	}

	[Token(Token = "0x600E290")]
	[Address(RVA = "0x25127FC", Offset = "0x25127FC", VA = "0x25127FC")]
	private void OnAgreeBtnClick()
	{
	}

	[Token(Token = "0x600E291")]
	[Address(RVA = "0x2512998", Offset = "0x2512998", VA = "0x2512998", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E292")]
	[Address(RVA = "0x2512B3C", Offset = "0x2512B3C", VA = "0x2512B3C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E293")]
	[Address(RVA = "0x2512C80", Offset = "0x2512C80", VA = "0x2512C80", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E294")]
	[Address(RVA = "0x2512D14", Offset = "0x2512D14", VA = "0x2512D14")]
	private void _003COnBlockBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600E295")]
	[Address(RVA = "0x2512EF0", Offset = "0x2512EF0", VA = "0x2512EF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E296")]
	[Address(RVA = "0x2512EF8", Offset = "0x2512EF8", VA = "0x2512EF8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E297")]
	[Address(RVA = "0x2512F00", Offset = "0x2512F00", VA = "0x2512F00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E298")]
	[Address(RVA = "0x2512F08", Offset = "0x2512F08", VA = "0x2512F08")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
