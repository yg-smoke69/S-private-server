using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F3C")]
public class UIFFWS03LobbyEntranceController : UIBigEventLobbyEntranceBaseController
{
	[Token(Token = "0x400C488")]
	[FieldOffset(Offset = "0x58")]
	private UIFFWS03LobbyEntranceView m_View;

	[Token(Token = "0x400C489")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelFFWS03 m_Model;

	[Token(Token = "0x6009A0E")]
	[Address(RVA = "0x19EB7BC", Offset = "0x19EB7BC", VA = "0x19EB7BC")]
	public UIFFWS03LobbyEntranceController()
	{
	}

	[Token(Token = "0x6009A0F")]
	[Address(RVA = "0x19EB7C4", Offset = "0x19EB7C4", VA = "0x19EB7C4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A10")]
	[Address(RVA = "0x19EB86C", Offset = "0x19EB86C", VA = "0x19EB86C", Slot = "31")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A11")]
	[Address(RVA = "0x19EB8C4", Offset = "0x19EB8C4", VA = "0x19EB8C4", Slot = "32")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A12")]
	[Address(RVA = "0x19EB91C", Offset = "0x19EB91C", VA = "0x19EB91C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009A13")]
	[Address(RVA = "0x19EBA48", Offset = "0x19EBA48", VA = "0x19EBA48", Slot = "33")]
	public override uint GetTipTypeValue()
	{
		return default(uint);
	}

	[Token(Token = "0x6009A14")]
	[Address(RVA = "0x19EBAA0", Offset = "0x19EBAA0", VA = "0x19EBAA0", Slot = "43")]
	public override bool IsShowRedPointTip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A15")]
	[Address(RVA = "0x19EBBBC", Offset = "0x19EBBBC", VA = "0x19EBBBC", Slot = "35")]
	public override string GetClickSoundId()
	{
		return null;
	}

	[Token(Token = "0x6009A16")]
	[Address(RVA = "0x19EBC60", Offset = "0x19EBC60", VA = "0x19EBC60")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009A17")]
	[Address(RVA = "0x19EBC68", Offset = "0x19EBC68", VA = "0x19EBC68")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009A18")]
	[Address(RVA = "0x19EBC70", Offset = "0x19EBC70", VA = "0x19EBC70")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009A19")]
	[Address(RVA = "0x19EBC78", Offset = "0x19EBC78", VA = "0x19EBC78")]
	public uint _003C_003EiFixBaseProxy_GetTipTypeValue()
	{
		return default(uint);
	}

	[Token(Token = "0x6009A1A")]
	[Address(RVA = "0x19EBC80", Offset = "0x19EBC80", VA = "0x19EBC80")]
	public bool _003C_003EiFixBaseProxy_IsShowRedPointTip()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A1B")]
	[Address(RVA = "0x19EBC88", Offset = "0x19EBC88", VA = "0x19EBC88")]
	public string _003C_003EiFixBaseProxy_GetClickSoundId()
	{
		return null;
	}
}
