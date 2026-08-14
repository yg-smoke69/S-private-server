using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032EC")]
public class NewBieGuildManager : SingletonModule<NewBieGuildManager>
{
	[Token(Token = "0x20032ED")]
	public class AvatarGuideData
	{
		[Token(Token = "0x40135D7")]
		[FieldOffset(Offset = "0x8")]
		public uint AvatarID;

		[Token(Token = "0x40135D8")]
		[FieldOffset(Offset = "0xC")]
		public uint StartLevel;

		[Token(Token = "0x40135D9")]
		[FieldOffset(Offset = "0x10")]
		public uint EndLevel;

		[Token(Token = "0x40135DA")]
		[FieldOffset(Offset = "0x14")]
		public string GuideType;

		[Token(Token = "0x6015777")]
		[Address(RVA = "0x28AFFA8", Offset = "0x28AFFA8", VA = "0x28AFFA8")]
		public AvatarGuideData()
		{
		}
	}

	[Token(Token = "0x20032EE")]
	private sealed class _003CCheckCanGuide_003Ec__AnonStorey0
	{
		[Token(Token = "0x40135DB")]
		[FieldOffset(Offset = "0x8")]
		internal NewbieGuideId guideID;

		[Token(Token = "0x6015778")]
		[Address(RVA = "0x28AFF5C", Offset = "0x28AFF5C", VA = "0x28AFF5C")]
		public _003CCheckCanGuide_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015779")]
		[Address(RVA = "0x28AFF64", Offset = "0x28AFF64", VA = "0x28AFF64")]
		internal bool _003C_003Em__0(NewBieGuildBasProcessor x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40135CA")]
	[FieldOffset(Offset = "0xA")]
	private bool m_IsNeedGuide;

	[Token(Token = "0x40135CB")]
	[FieldOffset(Offset = "0xC")]
	private NewBieGuildBasProcessor m_CurretGuide;

	[Token(Token = "0x40135CC")]
	[FieldOffset(Offset = "0x10")]
	private List<NewBieGuildBasProcessor> m_NewBieGuideList;

	[Token(Token = "0x40135CD")]
	[FieldOffset(Offset = "0x14")]
	private UIRightReigonClickMask m_ClickMask;

	[Token(Token = "0x40135CE")]
	[FieldOffset(Offset = "0x18")]
	private UIWidget m_BtnStartWidget;

	[Token(Token = "0x40135CF")]
	public const string IsForceGuide = "IsForceGuide";

	[Token(Token = "0x40135D0")]
	public const string AvatarProfileGuide = "AvatarProfileGuide";

	[Token(Token = "0x40135D1")]
	public const string AvatarSkillGuide = "AvatarSkillGuide";

	[Token(Token = "0x40135D2")]
	public const string AvatarMoreSkillGuide = "AvatarMoreSkillGuide";

	[Token(Token = "0x40135D3")]
	[FieldOffset(Offset = "0x1C")]
	private List<int> m_NewbieAvatarGuideID;

	[Token(Token = "0x40135D4")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, string> m_GuideTypeDict;

	[Token(Token = "0x40135D5")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, AvatarGuideData> m_AvatarGuideDataDict;

	[Token(Token = "0x40135D6")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<NewBieGuildBasProcessor> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601575E")]
	[Address(RVA = "0x2296D30", Offset = "0x2296D30", VA = "0x2296D30")]
	public NewBieGuildManager()
	{
	}

	[Token(Token = "0x601575F")]
	[Address(RVA = "0x2296F6C", Offset = "0x2296F6C", VA = "0x2296F6C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6015760")]
	[Address(RVA = "0x2297084", Offset = "0x2297084", VA = "0x2297084", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015761")]
	[Address(RVA = "0x22974B0", Offset = "0x22974B0", VA = "0x22974B0")]
	public void SetToGuide(bool flag)
	{
	}

	[Token(Token = "0x6015762")]
	[Address(RVA = "0x2297510", Offset = "0x2297510", VA = "0x2297510")]
	private void InitGuideList()
	{
	}

	[Token(Token = "0x6015763")]
	[Address(RVA = "0x229765C", Offset = "0x229765C", VA = "0x229765C")]
	public void SetWidgets(UIWidget[] widgetArray)
	{
	}

	[Token(Token = "0x6015764")]
	[Address(RVA = "0x229799C", Offset = "0x229799C", VA = "0x229799C")]
	public void SetBtnStartWidget(UIWidget newWidget)
	{
	}

	[Token(Token = "0x6015765")]
	[Address(RVA = "0x22979FC", Offset = "0x22979FC", VA = "0x22979FC")]
	public void ClearRefenceWidgets()
	{
	}

	[Token(Token = "0x6015766")]
	[Address(RVA = "0x2297B64", Offset = "0x2297B64", VA = "0x2297B64")]
	public void OpenGuide()
	{
	}

	[Token(Token = "0x6015767")]
	[Address(RVA = "0x2297F88", Offset = "0x2297F88", VA = "0x2297F88")]
	private void UpdateClickMask()
	{
	}

	[Token(Token = "0x6015768")]
	[Address(RVA = "0x2295814", Offset = "0x2295814", VA = "0x2295814")]
	public void CloseClickMask()
	{
	}

	[Token(Token = "0x6015769")]
	[Address(RVA = "0x22982F8", Offset = "0x22982F8", VA = "0x22982F8")]
	public bool CheckInGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x601576A")]
	[Address(RVA = "0x229835C", Offset = "0x229835C", VA = "0x229835C")]
	public bool CheckInRankingGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x601576B")]
	[Address(RVA = "0x22981E4", Offset = "0x22981E4", VA = "0x22981E4")]
	private bool CheckInAvaterGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x601576C")]
	[Address(RVA = "0x2298440", Offset = "0x2298440", VA = "0x2298440")]
	public NewbieGuideId GetCurrentGuideId()
	{
		return default(NewbieGuideId);
	}

	[Token(Token = "0x601576D")]
	[Address(RVA = "0x2297CF4", Offset = "0x2297CF4", VA = "0x2297CF4")]
	public void CloseGuide()
	{
	}

	[Token(Token = "0x601576E")]
	[Address(RVA = "0x22984B0", Offset = "0x22984B0", VA = "0x22984B0")]
	public void HideCurGuide()
	{
	}

	[Token(Token = "0x601576F")]
	[Address(RVA = "0x22985D4", Offset = "0x22985D4", VA = "0x22985D4")]
	public bool CheckCanGuide(NewbieGuideId guideID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015770")]
	[Address(RVA = "0x2297E18", Offset = "0x2297E18", VA = "0x2297E18")]
	private void ChooseGuide()
	{
	}

	[Token(Token = "0x6015771")]
	[Address(RVA = "0x2298738", Offset = "0x2298738", VA = "0x2298738")]
	private string GetAvatarGuideTypeByGuideID(int guideID)
	{
		return null;
	}

	[Token(Token = "0x6015772")]
	[Address(RVA = "0x2298864", Offset = "0x2298864", VA = "0x2298864")]
	public AvatarGuideData GetAvatarGuideByAvatarID(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6015773")]
	[Address(RVA = "0x229894C", Offset = "0x229894C", VA = "0x229894C")]
	public bool NeedShowMoreFreeSkillGuide(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6015774")]
	[Address(RVA = "0x2297154", Offset = "0x2297154", VA = "0x2297154")]
	private void InitAvatarGuideData()
	{
	}

	[Token(Token = "0x6015775")]
	[Address(RVA = "0x2298CAC", Offset = "0x2298CAC", VA = "0x2298CAC")]
	public bool IsAvatarSkillGuideLevel(uint level)
	{
		return default(bool);
	}

	[Token(Token = "0x6015776")]
	[Address(RVA = "0x2298FA8", Offset = "0x2298FA8", VA = "0x2298FA8")]
	private static int _003CSetWidgets_003Em__0(NewBieGuildBasProcessor a, NewBieGuildBasProcessor b)
	{
		return default(int);
	}
}
