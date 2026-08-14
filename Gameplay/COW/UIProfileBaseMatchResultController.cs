using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A84")]
public class UIProfileBaseMatchResultController : UIPopupWindowController
{
	[Token(Token = "0x4010525")]
	[FieldOffset(Offset = "0x46")]
	protected bool HideGradeInfo;

	[Token(Token = "0x4010526")]
	[FieldOffset(Offset = "0x48")]
	protected EMatchResultPageType m_PageType;

	[Token(Token = "0x4010527")]
	[FieldOffset(Offset = "0x4C")]
	private List<int> m_InfoTypeList;

	[Token(Token = "0x4010528")]
	[FieldOffset(Offset = "0x50")]
	private List<int> m_InfoTypeListData;

	[Token(Token = "0x170012C5")]
	protected List<int> InfoTypeList
	{
		[Token(Token = "0x6011504")]
		[Address(RVA = "0xF04930", Offset = "0xF04930", VA = "0xF04930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012C6")]
	protected List<int> InfoTypeListData
	{
		[Token(Token = "0x6011505")]
		[Address(RVA = "0xF04A08", Offset = "0xF04A08", VA = "0xF04A08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6011503")]
	[Address(RVA = "0xF03CB8", Offset = "0xF03CB8", VA = "0xF03CB8")]
	public UIProfileBaseMatchResultController()
	{
	}

	[Token(Token = "0x6011506")]
	[Address(RVA = "0xF080E0", Offset = "0xF080E0", VA = "0xF080E0")]
	public List<int> GetCurrentInfoTypeList()
	{
		return null;
	}

	[Token(Token = "0x6011507")]
	[Address(RVA = "0xF0A8C4", Offset = "0xF0A8C4", VA = "0xF0A8C4", Slot = "46")]
	protected virtual int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x6011508")]
	[Address(RVA = "0xF099B4", Offset = "0xF099B4", VA = "0xF099B4", Slot = "47")]
	protected virtual int[] GetInfoTypesData()
	{
		return null;
	}

	[Token(Token = "0x6011509")]
	[Address(RVA = "0xF04570", Offset = "0xF04570", VA = "0xF04570", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601150A")]
	[Address(RVA = "0xF09A9C", Offset = "0xF09A9C", VA = "0xF09A9C", Slot = "48")]
	protected virtual void OnChangePageType()
	{
	}

	[Token(Token = "0x601150B")]
	[Address(RVA = "0xF09AF4", Offset = "0xF09AF4", VA = "0xF09AF4", Slot = "49")]
	protected virtual void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x601150C")]
	[Address(RVA = "0xF08928", Offset = "0xF08928", VA = "0xF08928")]
	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	[Token(Token = "0x601150D")]
	[Address(RVA = "0xF0B5C0", Offset = "0xF0B5C0", VA = "0xF0B5C0")]
	protected void UpdateInfoTitle(UISprite infoSprite, int index)
	{
	}

	[Token(Token = "0x601150E")]
	[Address(RVA = "0xF0B740", Offset = "0xF0B740", VA = "0xF0B740")]
	public static string SetMatchResultPlayerInfoString(UISprite sprite, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	[Token(Token = "0x601150F")]
	[Address(RVA = "0xF0A994", Offset = "0xF0A994", VA = "0xF0A994")]
	public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	[Token(Token = "0x6011510")]
	[Address(RVA = "0xF0BC68", Offset = "0xF0BC68", VA = "0xF0BC68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
