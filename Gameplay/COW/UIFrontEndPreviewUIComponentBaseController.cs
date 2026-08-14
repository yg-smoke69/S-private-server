using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CC9")]
public abstract class UIFrontEndPreviewUIComponentBaseController : UIBaseController
{
	[Token(Token = "0x4011160")]
	[FieldOffset(Offset = "0x28")]
	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	[Token(Token = "0x4011161")]
	[FieldOffset(Offset = "0x2C")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4011162")]
	[FieldOffset(Offset = "0x30")]
	private uint _003CCurrentItemID_003Ek__BackingField;

	[Token(Token = "0x1700134B")]
	public uint CurrentItemID
	{
		[Token(Token = "0x6012BF5")]
		[Address(RVA = "0xE8CB08", Offset = "0xE8CB08", VA = "0xE8CB08")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6012BF6")]
		[Address(RVA = "0xE90134", Offset = "0xE90134", VA = "0xE90134")]
		set
		{
		}
	}

	[Token(Token = "0x6012BEE")]
	[Address(RVA = "0xE8FF18", Offset = "0xE8FF18", VA = "0xE8FF18")]
	protected UIFrontEndPreviewUIComponentBaseController()
	{
	}

	[Token(Token = "0x6012BEF")]
	protected abstract void InitBaseUIView();

	[Token(Token = "0x6012BF0")]
	[Address(RVA = "0xE862B8", Offset = "0xE862B8", VA = "0xE862B8", Slot = "32")]
	protected virtual void InitView()
	{
	}

	[Token(Token = "0x6012BF1")]
	[Address(RVA = "0xE8FF9C", Offset = "0xE8FF9C", VA = "0xE8FF9C")]
	public void SetFrontEndPreviewUIConfigData(FrontEndPreviewUIConfigData data)
	{
	}

	[Token(Token = "0x6012BF2")]
	[Address(RVA = "0xE90014", Offset = "0xE90014", VA = "0xE90014", Slot = "33")]
	protected virtual void OnSetFrontEndPreviewUIConfigData()
	{
	}

	[Token(Token = "0x6012BF3")]
	[Address(RVA = "0xE90068", Offset = "0xE90068", VA = "0xE90068")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent component)
	{
	}

	[Token(Token = "0x6012BF4")]
	[Address(RVA = "0xE900E0", Offset = "0xE900E0", VA = "0xE900E0", Slot = "34")]
	protected virtual void OnSetFrontEndPreviewComponent()
	{
	}
}
