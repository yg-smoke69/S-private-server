using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B79")]
public class UITrainingCampMemberProgressPinController : UIBaseController
{
	[Token(Token = "0x4010A53")]
	[FieldOffset(Offset = "0x28")]
	private UITrainingCampMemberProgressPinView m_View;

	[Token(Token = "0x4010A54")]
	[FieldOffset(Offset = "0x2C")]
	private UISprite[] m_HeadPicArr;

	[Token(Token = "0x4010A55")]
	[FieldOffset(Offset = "0x30")]
	private uint m_ProgressValue;

	[Token(Token = "0x4010A56")]
	[FieldOffset(Offset = "0x34")]
	private uint m_Count;

	[Token(Token = "0x4010A57")]
	public const string DEFAULT_HEADICON = "Icon_face_normal";

	[Token(Token = "0x170012ED")]
	public uint ProgressValue
	{
		[Token(Token = "0x6011F42")]
		[Address(RVA = "0x1C1A490", Offset = "0x1C1A490", VA = "0x1C1A490")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6011F41")]
		[Address(RVA = "0x1C1A434", Offset = "0x1C1A434", VA = "0x1C1A434")]
		set
		{
		}
	}

	[Token(Token = "0x6011F3E")]
	[Address(RVA = "0x1C19FF4", Offset = "0x1C19FF4", VA = "0x1C19FF4")]
	public UITrainingCampMemberProgressPinController()
	{
	}

	[Token(Token = "0x6011F3F")]
	[Address(RVA = "0x1C1A094", Offset = "0x1C1A094", VA = "0x1C1A094")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011F40")]
	[Address(RVA = "0x1C1A138", Offset = "0x1C1A138", VA = "0x1C1A138", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011F43")]
	[Address(RVA = "0x1C1A4E8", Offset = "0x1C1A4E8", VA = "0x1C1A4E8")]
	public bool AddHeadPic(uint headPicId)
	{
		return default(bool);
	}

	[Token(Token = "0x6011F44")]
	[Address(RVA = "0x1C1A824", Offset = "0x1C1A824", VA = "0x1C1A824")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
