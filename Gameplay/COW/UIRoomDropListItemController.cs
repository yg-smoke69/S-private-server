using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AE2")]
public class UIRoomDropListItemController : UIBaseController
{
	[Token(Token = "0x401075D")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomDropListItemView m_View;

	[Token(Token = "0x401075E")]
	[FieldOffset(Offset = "0x2C")]
	private DropListConfigInfo m_Info;

	[Token(Token = "0x401075F")]
	[FieldOffset(Offset = "0x30")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x4010760")]
	[FieldOffset(Offset = "0x34")]
	private UIModelCustomRoom m_ModelRoom;

	[Token(Token = "0x6011962")]
	[Address(RVA = "0x23BC22C", Offset = "0x23BC22C", VA = "0x23BC22C")]
	public UIRoomDropListItemController()
	{
	}

	[Token(Token = "0x6011963")]
	[Address(RVA = "0x23BC2B0", Offset = "0x23BC2B0", VA = "0x23BC2B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011964")]
	[Address(RVA = "0x23BC354", Offset = "0x23BC354", VA = "0x23BC354", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011965")]
	[Address(RVA = "0x23BC578", Offset = "0x23BC578", VA = "0x23BC578", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011966")]
	[Address(RVA = "0x23BC5DC", Offset = "0x23BC5DC", VA = "0x23BC5DC")]
	public void SetData(DropListConfigInfo info)
	{
	}

	[Token(Token = "0x6011967")]
	[Address(RVA = "0x23BC988", Offset = "0x23BC988", VA = "0x23BC988")]
	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	[Token(Token = "0x6011968")]
	[Address(RVA = "0x23BC9F8", Offset = "0x23BC9F8", VA = "0x23BC9F8")]
	public uint GetConfigInfoID()
	{
		return default(uint);
	}

	[Token(Token = "0x6011969")]
	[Address(RVA = "0x23BCA68", Offset = "0x23BCA68", VA = "0x23BCA68")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x601196A")]
	[Address(RVA = "0x23BCC84", Offset = "0x23BCC84", VA = "0x23BCC84")]
	private void OnGameModeSelected(object[] data)
	{
	}

	[Token(Token = "0x601196B")]
	[Address(RVA = "0x23BCD88", Offset = "0x23BCD88", VA = "0x23BCD88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601196C")]
	[Address(RVA = "0x23BCD90", Offset = "0x23BCD90", VA = "0x23BCD90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
