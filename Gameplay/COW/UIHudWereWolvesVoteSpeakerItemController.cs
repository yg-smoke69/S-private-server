using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028CD")]
public class UIHudWereWolvesVoteSpeakerItemController : UIEasyListItemController
{
	[Token(Token = "0x400FB00")]
	[FieldOffset(Offset = "0x38")]
	private UIHudWereWolvesVoteSpeakerItemView m_View;

	[Token(Token = "0x400FB01")]
	[FieldOffset(Offset = "0x40")]
	private IHAAMHPPLMG m_PlayerId;

	[Token(Token = "0x400FB02")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_UserId;

	[Token(Token = "0x6010145")]
	[Address(RVA = "0x293DEA8", Offset = "0x293DEA8", VA = "0x293DEA8")]
	public UIHudWereWolvesVoteSpeakerItemController()
	{
	}

	[Token(Token = "0x6010146")]
	[Address(RVA = "0x293DEB0", Offset = "0x293DEB0", VA = "0x293DEB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010147")]
	[Address(RVA = "0x293DF58", Offset = "0x293DF58", VA = "0x293DF58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010148")]
	[Address(RVA = "0x293E148", Offset = "0x293E148", VA = "0x293E148", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010149")]
	[Address(RVA = "0x293E27C", Offset = "0x293E27C", VA = "0x293E27C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601014A")]
	[Address(RVA = "0x293EA6C", Offset = "0x293EA6C", VA = "0x293EA6C")]
	private void OnSpeakerClick()
	{
	}

	[Token(Token = "0x601014B")]
	[Address(RVA = "0x293E8EC", Offset = "0x293E8EC", VA = "0x293E8EC")]
	private void RefreshSpeaker()
	{
	}

	[Token(Token = "0x601014C")]
	[Address(RVA = "0x293EE28", Offset = "0x293EE28", VA = "0x293EE28")]
	private void OnMuteStateChange(object[] data)
	{
	}

	[Token(Token = "0x601014D")]
	[Address(RVA = "0x293F098", Offset = "0x293F098", VA = "0x293F098")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601014E")]
	[Address(RVA = "0x293F0A0", Offset = "0x293F0A0", VA = "0x293F0A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
