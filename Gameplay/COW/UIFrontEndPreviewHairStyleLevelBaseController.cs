using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CB3")]
public abstract class UIFrontEndPreviewHairStyleLevelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewHairStyleLevelBaseView>
{
	[Token(Token = "0x401110B")]
	[FieldOffset(Offset = "0x38")]
	private List<UIToggleButton> m_HairStyleBtn;

	[Token(Token = "0x6012B68")]
	[Address(RVA = "0x27FA64C", Offset = "0x27FA64C", VA = "0x27FA64C")]
	protected UIFrontEndPreviewHairStyleLevelBaseController()
	{
	}

	[Token(Token = "0x6012B69")]
	[Address(RVA = "0x27FA6B0", Offset = "0x27FA6B0", VA = "0x27FA6B0", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012B6A")]
	[Address(RVA = "0x27FA86C", Offset = "0x27FA86C", VA = "0x27FA86C")]
	private void InitHairStyleBtnList()
	{
	}

	[Token(Token = "0x6012B6B")]
	[Address(RVA = "0x27FAC08", Offset = "0x27FAC08", VA = "0x27FAC08")]
	private void OnBtnHairStyleConClick()
	{
	}

	[Token(Token = "0x6012B6C")]
	[Address(RVA = "0x27FAE30", Offset = "0x27FAE30", VA = "0x27FAE30")]
	private void OnBtnSpreadCLick()
	{
	}

	[Token(Token = "0x6012B6D")]
	[Address(RVA = "0x27EB0AC", Offset = "0x27EB0AC", VA = "0x27EB0AC")]
	public void ClickDefaultHairStyle()
	{
	}

	[Token(Token = "0x6012B6E")]
	[Address(RVA = "0x27EB394", Offset = "0x27EB394", VA = "0x27EB394")]
	public void ClickDefaultEpicClothStyle()
	{
	}

	[Token(Token = "0x6012B6F")]
	[Address(RVA = "0x27FAF68", Offset = "0x27FAF68", VA = "0x27FAF68")]
	private void RefreshHairStyleItemByLv(int level)
	{
	}

	[Token(Token = "0x6012B70")]
	[Address(RVA = "0x27F431C", Offset = "0x27F431C", VA = "0x27F431C")]
	public void SetHairStyleIconVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B71")]
	[Address(RVA = "0x27F4684", Offset = "0x27F4684", VA = "0x27F4684")]
	public void SetEpicClothStyleIconVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012B72")]
	[Address(RVA = "0x27FB370", Offset = "0x27FB370", VA = "0x27FB370")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
