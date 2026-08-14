using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002625")]
public class UIFriendRelationshipGraphItemController : UIBaseController
{
	[Token(Token = "0x400EBA0")]
	[FieldOffset(Offset = "0x28")]
	private UIFriendRelationshipGraphItemView m_View;

	[Token(Token = "0x400EBA1")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_AccountID;

	[Token(Token = "0x400EBA2")]
	[FieldOffset(Offset = "0x38")]
	private uint m_FriendTag;

	[Token(Token = "0x400EBA3")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsSelf;

	[Token(Token = "0x400EBA4")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_IsFriend;

	[Token(Token = "0x400EBA5")]
	[FieldOffset(Offset = "0x40")]
	private EUIFriendRelationshipType m_RelationshipType;

	[Token(Token = "0x400EBA6")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 m_HeadIconSize;

	[Token(Token = "0x400EBA7")]
	[FieldOffset(Offset = "0x4C")]
	public Action fnClickHeadIconCallBack;

	[Token(Token = "0x1700116E")]
	public ulong AccountID
	{
		[Token(Token = "0x600E25F")]
		[Address(RVA = "0x250D13C", Offset = "0x250D13C", VA = "0x250D13C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x600E25D")]
	[Address(RVA = "0x250D27C", Offset = "0x250D27C", VA = "0x250D27C")]
	public UIFriendRelationshipGraphItemController()
	{
	}

	[Token(Token = "0x600E25E")]
	[Address(RVA = "0x250D34C", Offset = "0x250D34C", VA = "0x250D34C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E260")]
	[Address(RVA = "0x250B458", Offset = "0x250B458", VA = "0x250B458")]
	public void SetData(FriendAccountInfo accountInfo, bool canAddFriend)
	{
	}

	[Token(Token = "0x600E261")]
	[Address(RVA = "0x250962C", Offset = "0x250962C", VA = "0x250962C")]
	public void SetData(BaseProfileInfo info, bool canAddFriend)
	{
	}

	[Token(Token = "0x600E262")]
	[Address(RVA = "0x250C41C", Offset = "0x250C41C", VA = "0x250C41C")]
	public void ClearData()
	{
	}

	[Token(Token = "0x600E263")]
	[Address(RVA = "0x25088EC", Offset = "0x25088EC", VA = "0x25088EC")]
	public void UpdateItemParam(UIFriendRelationshipGraphContainer container)
	{
	}

	[Token(Token = "0x600E264")]
	[Address(RVA = "0x250C01C", Offset = "0x250C01C", VA = "0x250C01C")]
	public void ShowAnimVFX()
	{
	}

	[Token(Token = "0x600E265")]
	[Address(RVA = "0x250D194", Offset = "0x250D194", VA = "0x250D194")]
	public void EanbelAddFriend(bool enabel)
	{
	}

	[Token(Token = "0x600E266")]
	[Address(RVA = "0x2509C24", Offset = "0x2509C24", VA = "0x2509C24")]
	public void SetIfSelf(bool self)
	{
	}

	[Token(Token = "0x600E267")]
	[Address(RVA = "0x250D4B8", Offset = "0x250D4B8", VA = "0x250D4B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E268")]
	[Address(RVA = "0x250D688", Offset = "0x250D688", VA = "0x250D688")]
	private void OnAddBtnClick()
	{
	}

	[Token(Token = "0x600E269")]
	[Address(RVA = "0x250D880", Offset = "0x250D880", VA = "0x250D880")]
	private void OnDetailInfoBtnClick()
	{
	}

	[Token(Token = "0x600E26A")]
	[Address(RVA = "0x250D3F0", Offset = "0x250D3F0", VA = "0x250D3F0")]
	private uint GetAddFriendTag(FriendAccountInfo accountInfo)
	{
		return default(uint);
	}

	[Token(Token = "0x600E26B")]
	[Address(RVA = "0x250DA2C", Offset = "0x250DA2C", VA = "0x250DA2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
