using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002085")]
public class UICupMatchTeamInviteItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400CBE3")]
	[FieldOffset(Offset = "0x38")]
	private UICupMatchTeamInviteItemView m_View;

	[Token(Token = "0x400CBE4")]
	[FieldOffset(Offset = "0x3C")]
	private FriendAccountInfo m_FriendAccountInfo;

	[Token(Token = "0x400CBE5")]
	[FieldOffset(Offset = "0x40")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400CBE6")]
	[FieldOffset(Offset = "0x44")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBE7")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchTeamInviteController m_Parent;

	[Token(Token = "0x400CBE8")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CupMatchKey;

	[Token(Token = "0x600A733")]
	[Address(RVA = "0x2ABE5EC", Offset = "0x2ABE5EC", VA = "0x2ABE5EC")]
	public UICupMatchTeamInviteItemController()
	{
	}

	[Token(Token = "0x600A734")]
	[Address(RVA = "0x2ABE5F4", Offset = "0x2ABE5F4", VA = "0x2ABE5F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A735")]
	[Address(RVA = "0x2ABE69C", Offset = "0x2ABE69C", VA = "0x2ABE69C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A736")]
	[Address(RVA = "0x2ABED28", Offset = "0x2ABED28", VA = "0x2ABED28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A737")]
	[Address(RVA = "0x2ABEFE0", Offset = "0x2ABEFE0", VA = "0x2ABEFE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A738")]
	[Address(RVA = "0x2ABCB9C", Offset = "0x2ABCB9C", VA = "0x2ABCB9C")]
	public void SetCupMatchKey(int key)
	{
	}

	[Token(Token = "0x600A739")]
	[Address(RVA = "0x2ABF068", Offset = "0x2ABF068", VA = "0x2ABF068")]
	private void Invite()
	{
	}

	[Token(Token = "0x600A73A")]
	[Address(RVA = "0x2ABE96C", Offset = "0x2ABE96C", VA = "0x2ABE96C")]
	private void UpdateInviteButtonView()
	{
	}

	[Token(Token = "0x600A73B")]
	[Address(RVA = "0x2ABF2BC", Offset = "0x2ABF2BC", VA = "0x2ABF2BC")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x600A73C")]
	[Address(RVA = "0x2ABF3B4", Offset = "0x2ABF3B4", VA = "0x2ABF3B4", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A73D")]
	[Address(RVA = "0x2ABF448", Offset = "0x2ABF448", VA = "0x2ABF448", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A73E")]
	[Address(RVA = "0x2ABF834", Offset = "0x2ABF834", VA = "0x2ABF834")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A73F")]
	[Address(RVA = "0x2ABF83C", Offset = "0x2ABF83C", VA = "0x2ABF83C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
