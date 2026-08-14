using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20026C8")]
public class UIHistoryTeammateController : UIBaseController
{
	[Token(Token = "0x400EF60")]
	[FieldOffset(Offset = "0x28")]
	private UIBriefProfileInfoController m_CallSign;

	[Token(Token = "0x400EF61")]
	[FieldOffset(Offset = "0x2C")]
	private UIHistoryTeammateView m_View;

	[Token(Token = "0x400EF62")]
	[FieldOffset(Offset = "0x30")]
	private BaseProfileInfo m_Info;

	[Token(Token = "0x600EA69")]
	[Address(RVA = "0x163316C", Offset = "0x163316C", VA = "0x163316C")]
	public UIHistoryTeammateController()
	{
	}

	[Token(Token = "0x600EA6A")]
	[Address(RVA = "0x16331F0", Offset = "0x16331F0", VA = "0x16331F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA6B")]
	[Address(RVA = "0x163334C", Offset = "0x163334C", VA = "0x163334C")]
	public void SetData(TeammateStats info)
	{
	}

	[Token(Token = "0x600EA6C")]
	[Address(RVA = "0x163370C", Offset = "0x163370C", VA = "0x163370C")]
	public void SetData(UGCPlayerStats stats, int[] scoreType, int ugcTemplateId)
	{
	}

	[Token(Token = "0x600EA6D")]
	[Address(RVA = "0x163355C", Offset = "0x163355C", VA = "0x163355C")]
	public void RefreshFriendBtnShow()
	{
	}

	[Token(Token = "0x600EA6E")]
	[Address(RVA = "0x1633B70", Offset = "0x1633B70", VA = "0x1633B70")]
	private void OnAddFriendClick()
	{
	}

	[Token(Token = "0x600EA6F")]
	[Address(RVA = "0x1633E58", Offset = "0x1633E58", VA = "0x1633E58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA70")]
	[Address(RVA = "0x1633EFC", Offset = "0x1633EFC", VA = "0x1633EFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
