using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002545")]
public class UIClanGroupRecruitController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002546")]
	private enum RankType
	{
		[Token(Token = "0x400E701")]
		BR,
		[Token(Token = "0x400E702")]
		CS
	}

	[Token(Token = "0x2002547")]
	private enum TagIndexType
	{
		[Token(Token = "0x400E704")]
		First,
		[Token(Token = "0x400E705")]
		Second
	}

	[Token(Token = "0x400E6F2")]
	[FieldOffset(Offset = "0x48")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E6F3")]
	[FieldOffset(Offset = "0x4C")]
	private UIClanGroupRecruitView m_View;

	[Token(Token = "0x400E6F4")]
	[FieldOffset(Offset = "0x50")]
	private UIPopMenuSmallControler m_SelectBRRankPopMenuSmallCtrl;

	[Token(Token = "0x400E6F5")]
	[FieldOffset(Offset = "0x54")]
	private UIPopMenuSmallControler m_SelectCSRankPopMenuSmallCtrl;

	[Token(Token = "0x400E6F6")]
	[FieldOffset(Offset = "0x58")]
	private UIPopMenuSmallControler m_SelectTagPopMenuSmallCtrl1;

	[Token(Token = "0x400E6F7")]
	[FieldOffset(Offset = "0x5C")]
	private UIPopMenuSmallControler m_SelectTagPopMenuSmallCtrl2;

	[Token(Token = "0x400E6F8")]
	[FieldOffset(Offset = "0x60")]
	private uint m_LimitBRRank;

	[Token(Token = "0x400E6F9")]
	[FieldOffset(Offset = "0x64")]
	private uint m_LimitCSRank;

	[Token(Token = "0x400E6FA")]
	[FieldOffset(Offset = "0x68")]
	private uint m_Tag1;

	[Token(Token = "0x400E6FB")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_Tag2;

	[Token(Token = "0x400E6FC")]
	private const int POPMENUWIDTH = 215;

	[Token(Token = "0x400E6FD")]
	private const int POPMENUWIDTH2 = 464;

	[Token(Token = "0x400E6FE")]
	[FieldOffset(Offset = "0x70")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400E6FF")]
	[FieldOffset(Offset = "0x74")]
	private PopMenuData m_DefaultMenuData;

	[Token(Token = "0x600D8F2")]
	[Address(RVA = "0x2F3DB04", Offset = "0x2F3DB04", VA = "0x2F3DB04")]
	public UIClanGroupRecruitController()
	{
	}

	[Token(Token = "0x600D8F3")]
	[Address(RVA = "0x2F3DB90", Offset = "0x2F3DB90", VA = "0x2F3DB90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D8F4")]
	[Address(RVA = "0x2F3DDC4", Offset = "0x2F3DDC4", VA = "0x2F3DDC4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D8F5")]
	[Address(RVA = "0x2F3DE4C", Offset = "0x2F3DE4C", VA = "0x2F3DE4C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D8F6")]
	[Address(RVA = "0x2F3EE38", Offset = "0x2F3EE38", VA = "0x2F3EE38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D8F7")]
	[Address(RVA = "0x2F3EEDC", Offset = "0x2F3EEDC", VA = "0x2F3EEDC")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600D8F8")]
	[Address(RVA = "0x2F3E088", Offset = "0x2F3E088", VA = "0x2F3E088")]
	private void InitDefaultUI()
	{
	}

	[Token(Token = "0x600D8F9")]
	[Address(RVA = "0x2F3F1B0", Offset = "0x2F3F1B0", VA = "0x2F3F1B0")]
	private void GenerateBRRankMenuData()
	{
	}

	[Token(Token = "0x600D8FA")]
	[Address(RVA = "0x2F3F7E4", Offset = "0x2F3F7E4", VA = "0x2F3F7E4")]
	private void GenerateCSRankMenuData()
	{
	}

	[Token(Token = "0x600D8FB")]
	[Address(RVA = "0x2F3FE18", Offset = "0x2F3FE18", VA = "0x2F3FE18")]
	private void OnCSRankSelected(object obj)
	{
	}

	[Token(Token = "0x600D8FC")]
	[Address(RVA = "0x2F3FEA8", Offset = "0x2F3FEA8", VA = "0x2F3FEA8")]
	private void OnBRRankSelected(object obj)
	{
	}

	[Token(Token = "0x600D8FD")]
	[Address(RVA = "0x2F3FF38", Offset = "0x2F3FF38", VA = "0x2F3FF38")]
	private void GenerateTag1Menu()
	{
	}

	[Token(Token = "0x600D8FE")]
	[Address(RVA = "0x2F40414", Offset = "0x2F40414", VA = "0x2F40414")]
	private void GenerateTag2Menu()
	{
	}

	[Token(Token = "0x600D8FF")]
	[Address(RVA = "0x2F3FF9C", Offset = "0x2F3FF9C", VA = "0x2F3FF9C")]
	private void GenerateTagMenu(TagIndexType index)
	{
	}

	[Token(Token = "0x600D900")]
	[Address(RVA = "0x2F40478", Offset = "0x2F40478", VA = "0x2F40478")]
	private void OnTag1Selected(object obj)
	{
	}

	[Token(Token = "0x600D901")]
	[Address(RVA = "0x2F40508", Offset = "0x2F40508", VA = "0x2F40508")]
	private void OnTag2Selected(object obj)
	{
	}

	[Token(Token = "0x600D902")]
	[Address(RVA = "0x2F40598", Offset = "0x2F40598", VA = "0x2F40598", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D903")]
	[Address(RVA = "0x2F4062C", Offset = "0x2F4062C", VA = "0x2F4062C")]
	private bool _003CInitDefaultUI_003Em__0(CSVBaseData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600D904")]
	[Address(RVA = "0x2F40750", Offset = "0x2F40750", VA = "0x2F40750")]
	private bool _003CInitDefaultUI_003Em__1(CSVBaseData data)
	{
		return default(bool);
	}

	[Token(Token = "0x600D905")]
	[Address(RVA = "0x2F40874", Offset = "0x2F40874", VA = "0x2F40874")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D906")]
	[Address(RVA = "0x2F4087C", Offset = "0x2F4087C", VA = "0x2F4087C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
