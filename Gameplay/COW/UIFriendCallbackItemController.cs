using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200261D")]
public class UIFriendCallbackItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400EB4A")]
	[FieldOffset(Offset = "0x38")]
	private UIFriendCallbackItemView m_View;

	[Token(Token = "0x400EB4B")]
	[FieldOffset(Offset = "0x3C")]
	private FriendAccountInfo m_Data;

	[Token(Token = "0x400EB4C")]
	[FieldOffset(Offset = "0x40")]
	private UIDragScrollView m_DragComponent;

	[Token(Token = "0x400EB4D")]
	[FieldOffset(Offset = "0x44")]
	private BoxCollider m_ItemCollider;

	[Token(Token = "0x1700115B")]
	public UIDragScrollView DragComponent
	{
		[Token(Token = "0x600E1D6")]
		[Address(RVA = "0x1B6E8E4", Offset = "0x1B6E8E4", VA = "0x1B6E8E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700115C")]
	public Vector2 ItemViewSize
	{
		[Token(Token = "0x600E1D8")]
		[Address(RVA = "0x1B6EA84", Offset = "0x1B6EA84", VA = "0x1B6EA84")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x600E1D5")]
	[Address(RVA = "0x1B6E8DC", Offset = "0x1B6E8DC", VA = "0x1B6E8DC")]
	public UIFriendCallbackItemController()
	{
	}

	[Token(Token = "0x600E1D7")]
	[Address(RVA = "0x1B6E9E0", Offset = "0x1B6E9E0", VA = "0x1B6E9E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1D9")]
	[Address(RVA = "0x1B6EC8C", Offset = "0x1B6EC8C", VA = "0x1B6EC8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1DA")]
	[Address(RVA = "0x1B6EE88", Offset = "0x1B6EE88", VA = "0x1B6EE88", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E1DB")]
	[Address(RVA = "0x1B6EFB8", Offset = "0x1B6EFB8", VA = "0x1B6EFB8")]
	public void SetData(FriendAccountInfo accountInfo)
	{
	}

	[Token(Token = "0x600E1DC")]
	[Address(RVA = "0x1B6F5C8", Offset = "0x1B6F5C8", VA = "0x1B6F5C8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E1DD")]
	[Address(RVA = "0x1B6F6CC", Offset = "0x1B6F6CC", VA = "0x1B6F6CC")]
	public void SetBigEventBg()
	{
	}

	[Token(Token = "0x600E1DE")]
	[Address(RVA = "0x1B6F7D4", Offset = "0x1B6F7D4", VA = "0x1B6F7D4", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E1DF")]
	[Address(RVA = "0x1B6F848", Offset = "0x1B6F848", VA = "0x1B6F848", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E1E0")]
	[Address(RVA = "0x1B6F8DC", Offset = "0x1B6F8DC", VA = "0x1B6F8DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E1E1")]
	[Address(RVA = "0x1B6F8E4", Offset = "0x1B6F8E4", VA = "0x1B6F8E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
