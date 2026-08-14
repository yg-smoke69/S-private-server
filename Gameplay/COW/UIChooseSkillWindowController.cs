using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002524")]
public class UIChooseSkillWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002525")]
	public enum SkillTemplateType
	{
		[Token(Token = "0x400E665")]
		SkillItem,
		[Token(Token = "0x400E666")]
		SplitLine,
		[Token(Token = "0x400E667")]
		ActiveEquipped
	}

	[Token(Token = "0x2002526")]
	private sealed class _003CGetSkillList_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E668")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelAvatarProfile model;

		[Token(Token = "0x600D80C")]
		[Address(RVA = "0x2F1E854", Offset = "0x2F1E854", VA = "0x2F1E854")]
		public _003CGetSkillList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D80D")]
		[Address(RVA = "0x2F1E85C", Offset = "0x2F1E85C", VA = "0x2F1E85C")]
		internal bool _003C_003Em__0(AvatarProfile a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E655")]
	[FieldOffset(Offset = "0x48")]
	private List<SkillInfo> m_SkillList;

	[Token(Token = "0x400E656")]
	[FieldOffset(Offset = "0x4C")]
	private UIChooseSkillWindowView m_View;

	[Token(Token = "0x400E657")]
	[FieldOffset(Offset = "0x50")]
	private int m_SlotIndex;

	[Token(Token = "0x400E658")]
	[FieldOffset(Offset = "0x54")]
	private uint m_CurrentShowAvatarid;

	[Token(Token = "0x400E659")]
	[FieldOffset(Offset = "0x58")]
	public bool m_ChooseSkillMenuCreated;

	[Token(Token = "0x400E65A")]
	[FieldOffset(Offset = "0x5C")]
	private string m_DeepLink;

	[Token(Token = "0x400E65B")]
	private const string DL_Positive = "Positive";

	[Token(Token = "0x400E65C")]
	private const string DL_Active = "Active";

	[Token(Token = "0x400E65D")]
	private const string AVATAR_SKILL_CHOOSE_ACTIVE = "AVATAR_SKILL_CHOOSE_ACTIVE";

	[Token(Token = "0x400E65E")]
	[FieldOffset(Offset = "0x60")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x400E65F")]
	[FieldOffset(Offset = "0x64")]
	private UIAvatarSkillSlotController slotctrl;

	[Token(Token = "0x400E660")]
	[FieldOffset(Offset = "0x68")]
	private int m_SkillNum;

	[Token(Token = "0x400E661")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_NeedGuide;

	[Token(Token = "0x400E662")]
	[FieldOffset(Offset = "0x6D")]
	private bool isClickClose;

	[Token(Token = "0x400E663")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AvatarProfile> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D7E7")]
	[Address(RVA = "0x208E520", Offset = "0x208E520", VA = "0x208E520")]
	public UIChooseSkillWindowController()
	{
	}

	[Token(Token = "0x600D7E8")]
	[Address(RVA = "0x208E5B4", Offset = "0x208E5B4", VA = "0x208E5B4", Slot = "31")]
	public override string Rule()
	{
		return null;
	}

	[Token(Token = "0x600D7E9")]
	[Address(RVA = "0x208E658", Offset = "0x208E658", VA = "0x208E658", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D7EA")]
	[Address(RVA = "0x208F038", Offset = "0x208F038", VA = "0x208F038")]
	private void SetNewbieGuide(int guideIndex, List<EventDelegate> guideAction)
	{
	}

	[Token(Token = "0x600D7EB")]
	[Address(RVA = "0x208ECCC", Offset = "0x208ECCC", VA = "0x208ECCC")]
	private void InitPositiveSkillTemplate()
	{
	}

	[Token(Token = "0x600D7EC")]
	[Address(RVA = "0x208EE48", Offset = "0x208EE48", VA = "0x208EE48")]
	private void InitActiveSkillTemplate()
	{
	}

	[Token(Token = "0x600D7ED")]
	[Address(RVA = "0x208F6D8", Offset = "0x208F6D8", VA = "0x208F6D8")]
	private void OnUpdateInfo(object[] data)
	{
	}

	[Token(Token = "0x600D7EE")]
	[Address(RVA = "0x2090164", Offset = "0x2090164", VA = "0x2090164")]
	private void OnBuyClick()
	{
	}

	[Token(Token = "0x600D7EF")]
	[Address(RVA = "0x20904F4", Offset = "0x20904F4", VA = "0x20904F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D7F0")]
	[Address(RVA = "0x2090598", Offset = "0x2090598", VA = "0x2090598", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D7F1")]
	[Address(RVA = "0x2090DD8", Offset = "0x2090DD8", VA = "0x2090DD8")]
	private void RefreshState(bool flag)
	{
	}

	[Token(Token = "0x600D7F2")]
	[Address(RVA = "0x2090F10", Offset = "0x2090F10", VA = "0x2090F10")]
	public void SetData(uint currentShowAvatarid, int slotindex)
	{
	}

	[Token(Token = "0x600D7F3")]
	[Address(RVA = "0x20911A4", Offset = "0x20911A4", VA = "0x20911A4")]
	private void OnHideBtnClick()
	{
	}

	[Token(Token = "0x600D7F4")]
	[Address(RVA = "0x20912C4", Offset = "0x20912C4", VA = "0x20912C4")]
	private void OnSkillEquip(object[] data)
	{
	}

	[Token(Token = "0x600D7F5")]
	[Address(RVA = "0x2091338", Offset = "0x2091338", VA = "0x2091338")]
	private void OnUpdateTips(object[] data)
	{
	}

	[Token(Token = "0x600D7F6")]
	[Address(RVA = "0x2091394", Offset = "0x2091394", VA = "0x2091394")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600D7F7")]
	[Address(RVA = "0x20915FC", Offset = "0x20915FC", VA = "0x20915FC")]
	private void PositiveListRefresh(List<SkillInfo> skilInfos)
	{
	}

	[Token(Token = "0x600D7F8")]
	[Address(RVA = "0x2091B58", Offset = "0x2091B58", VA = "0x2091B58")]
	private void ActiveListRefresh(List<SkillInfo> skillInfos, bool hasEquippedActiveSkill = false)
	{
	}

	[Token(Token = "0x600D7F9")]
	[Address(RVA = "0x209251C", Offset = "0x209251C", VA = "0x209251C")]
	public Transform GetTipsTr()
	{
		return null;
	}

	[Token(Token = "0x600D7FA")]
	[Address(RVA = "0x209258C", Offset = "0x209258C", VA = "0x209258C")]
	public int GetDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600D7FB")]
	[Address(RVA = "0x2092618", Offset = "0x2092618", VA = "0x2092618")]
	private int GetSkillColor(char color)
	{
		return default(int);
	}

	[Token(Token = "0x600D7FC")]
	[Address(RVA = "0x20926B4", Offset = "0x20926B4", VA = "0x20926B4")]
	private int SkillCompare(SkillInfo a, SkillInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600D7FD")]
	[Address(RVA = "0x2091148", Offset = "0x2091148", VA = "0x2091148")]
	private void CreateLeaderBoardMenu()
	{
	}

	[Token(Token = "0x600D7FE")]
	[Address(RVA = "0x208F7C4", Offset = "0x208F7C4", VA = "0x208F7C4")]
	private void OnPositiveMenuSelected()
	{
	}

	[Token(Token = "0x600D7FF")]
	[Address(RVA = "0x208FB08", Offset = "0x208FB08", VA = "0x208FB08")]
	private void OnActiveMenuSelected()
	{
	}

	[Token(Token = "0x600D800")]
	[Address(RVA = "0x2093F3C", Offset = "0x2093F3C", VA = "0x2093F3C")]
	private uint GetCurrentEquippedActiveSkill()
	{
		return default(uint);
	}

	[Token(Token = "0x600D801")]
	[Address(RVA = "0x2092BD0", Offset = "0x2092BD0", VA = "0x2092BD0")]
	private void GetSkillList(bool isActiveSkill)
	{
	}

	[Token(Token = "0x600D802")]
	[Address(RVA = "0x2093EE8", Offset = "0x2093EE8", VA = "0x2093EE8")]
	private void FinishSkillGuide()
	{
	}

	[Token(Token = "0x600D803")]
	[Address(RVA = "0x2094134", Offset = "0x2094134", VA = "0x2094134")]
	private IUITable2Item _003CInitPositiveSkillTemplate_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x600D804")]
	[Address(RVA = "0x20944E0", Offset = "0x20944E0", VA = "0x20944E0")]
	private IUITable2Item _003CInitPositiveSkillTemplate_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x600D805")]
	[Address(RVA = "0x2094638", Offset = "0x2094638", VA = "0x2094638")]
	private IUITable2Item _003CInitActiveSkillTemplate_003Em__2()
	{
		return null;
	}

	[Token(Token = "0x600D806")]
	[Address(RVA = "0x2094774", Offset = "0x2094774", VA = "0x2094774")]
	private IUITable2Item _003CInitActiveSkillTemplate_003Em__3()
	{
		return null;
	}

	[Token(Token = "0x600D807")]
	[Address(RVA = "0x20948CC", Offset = "0x20948CC", VA = "0x20948CC")]
	private IUITable2Item _003CInitActiveSkillTemplate_003Em__4()
	{
		return null;
	}

	[Token(Token = "0x600D808")]
	[Address(RVA = "0x2094E70", Offset = "0x2094E70", VA = "0x2094E70")]
	private static bool _003COnActiveMenuSelected_003Em__5(AvatarProfile a)
	{
		return default(bool);
	}

	[Token(Token = "0x600D809")]
	[Address(RVA = "0x2094E94", Offset = "0x2094E94", VA = "0x2094E94")]
	public string _003C_003EiFixBaseProxy_Rule()
	{
		return null;
	}

	[Token(Token = "0x600D80A")]
	[Address(RVA = "0x2094E9C", Offset = "0x2094E9C", VA = "0x2094E9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D80B")]
	[Address(RVA = "0x2094EA4", Offset = "0x2094EA4", VA = "0x2094EA4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
