using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F9F")]
public class UIHUDArmsRaceBonusCardController : UIBaseController
{
	[Token(Token = "0x400C65E")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsRaceBonucCardView m_view;

	[Token(Token = "0x6009D7E")]
	[Address(RVA = "0x166C6D8", Offset = "0x166C6D8", VA = "0x166C6D8")]
	public UIHUDArmsRaceBonusCardController()
	{
	}

	[Token(Token = "0x6009D7F")]
	[Address(RVA = "0x166C75C", Offset = "0x166C75C", VA = "0x166C75C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D80")]
	[Address(RVA = "0x166C804", Offset = "0x166C804", VA = "0x166C804", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D81")]
	[Address(RVA = "0x166CA60", Offset = "0x166CA60", VA = "0x166CA60", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009D82")]
	[Address(RVA = "0x166CB94", Offset = "0x166CB94", VA = "0x166CB94")]
	private void OnUseCard()
	{
	}

	[Token(Token = "0x6009D83")]
	[Address(RVA = "0x166CCB0", Offset = "0x166CCB0", VA = "0x166CCB0")]
	private void OnLocalPlayerGetPoint(object[] param)
	{
	}

	[Token(Token = "0x6009D84")]
	[Address(RVA = "0x166CD24", Offset = "0x166CD24", VA = "0x166CD24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D85")]
	[Address(RVA = "0x166CD2C", Offset = "0x166CD2C", VA = "0x166CD2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
