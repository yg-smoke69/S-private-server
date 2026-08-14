using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002835")]
public class UIHudReservationItemController : UIBaseController
{
	[Token(Token = "0x400F814")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReservationItemView m_View;

	[Token(Token = "0x400F815")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelTeamReserve m_Model;

	[Token(Token = "0x400F816")]
	[FieldOffset(Offset = "0x30")]
	private FriendAccountInfo m_Friend;

	[Token(Token = "0x600FACB")]
	[Address(RVA = "0x13F1038", Offset = "0x13F1038", VA = "0x13F1038")]
	public UIHudReservationItemController()
	{
	}

	[Token(Token = "0x600FACC")]
	[Address(RVA = "0x13F10BC", Offset = "0x13F10BC", VA = "0x13F10BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FACD")]
	[Address(RVA = "0x13F133C", Offset = "0x13F133C", VA = "0x13F133C")]
	private void InitView()
	{
	}

	[Token(Token = "0x600FACE")]
	[Address(RVA = "0x13F1444", Offset = "0x13F1444", VA = "0x13F1444")]
	public void SetData(ulong id, UIModelTeamReserve.ReserveReplyStatus status)
	{
	}

	[Token(Token = "0x600FACF")]
	[Address(RVA = "0x13F1BB4", Offset = "0x13F1BB4", VA = "0x13F1BB4")]
	private void OnAgreeBtnClick()
	{
	}

	[Token(Token = "0x600FAD0")]
	[Address(RVA = "0x13F1C68", Offset = "0x13F1C68", VA = "0x13F1C68")]
	private void OnRejectBtnClick()
	{
	}

	[Token(Token = "0x600FAD1")]
	[Address(RVA = "0x13F1D1C", Offset = "0x13F1D1C", VA = "0x13F1D1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FAD2")]
	[Address(RVA = "0x13F1DC0", Offset = "0x13F1DC0", VA = "0x13F1DC0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
