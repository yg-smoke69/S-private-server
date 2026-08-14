using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F53")]
public class UIActivityCollectionSigninItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400C4DA")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityCollectionSigninItemView m_View;

	[Token(Token = "0x400C4DB")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_ID;

	[Token(Token = "0x400C4DC")]
	[FieldOffset(Offset = "0x30")]
	private FestivalAttendanceItem m_Info;

	[Token(Token = "0x400C4DD")]
	[FieldOffset(Offset = "0x34")]
	private UIModelActivity m_Model;

	[Token(Token = "0x400C4DE")]
	private const uint GREY_COLOR = 2122219263u;

	[Token(Token = "0x400C4DF")]
	private const uint YELLOW_COLOR = 4120519679u;

	[Token(Token = "0x400C4E0")]
	[FieldOffset(Offset = "0x38")]
	private int m_NowDay;

	[Token(Token = "0x400C4E1")]
	[FieldOffset(Offset = "0x3C")]
	private UIStandardItemMAXBController m_AwardUI;

	[Token(Token = "0x6009AF0")]
	[Address(RVA = "0x2A0C028", Offset = "0x2A0C028", VA = "0x2A0C028")]
	public UIActivityCollectionSigninItemController()
	{
	}

	[Token(Token = "0x6009AF1")]
	[Address(RVA = "0x2A0A530", Offset = "0x2A0A530", VA = "0x2A0A530")]
	public bool IsSignButNotClaimed()
	{
		return default(bool);
	}

	[Token(Token = "0x6009AF2")]
	[Address(RVA = "0x2A0B264", Offset = "0x2A0B264", VA = "0x2A0B264")]
	public bool IsNowDay()
	{
		return default(bool);
	}

	[Token(Token = "0x6009AF3")]
	[Address(RVA = "0x2A0C0AC", Offset = "0x2A0C0AC", VA = "0x2A0C0AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009AF4")]
	[Address(RVA = "0x2A0C150", Offset = "0x2A0C150", VA = "0x2A0C150", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009AF5")]
	[Address(RVA = "0x2A0C340", Offset = "0x2A0C340", VA = "0x2A0C340", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009AF6")]
	[Address(RVA = "0x2A0C3C8", Offset = "0x2A0C3C8", VA = "0x2A0C3C8")]
	public void OnClickClaimed()
	{
	}

	[Token(Token = "0x6009AF7")]
	[Address(RVA = "0x2A0A7A4", Offset = "0x2A0A7A4", VA = "0x2A0A7A4")]
	public void SetData(FestivalAttendanceItem info)
	{
	}

	[Token(Token = "0x6009AF8")]
	[Address(RVA = "0x2A0C448", Offset = "0x2A0C448", VA = "0x2A0C448")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x6009AF9")]
	[Address(RVA = "0x2A0C8A8", Offset = "0x2A0C8A8", VA = "0x2A0C8A8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009AFA")]
	[Address(RVA = "0x2A0CA04", Offset = "0x2A0CA04", VA = "0x2A0CA04", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009AFB")]
	[Address(RVA = "0x2A0CA98", Offset = "0x2A0CA98", VA = "0x2A0CA98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009AFC")]
	[Address(RVA = "0x2A0CAA0", Offset = "0x2A0CAA0", VA = "0x2A0CAA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
