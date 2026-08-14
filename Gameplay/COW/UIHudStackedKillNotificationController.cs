using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200285B")]
internal class UIHudStackedKillNotificationController : UIHudKillNotificationBaseController
{
	[Token(Token = "0x200285C")]
	private sealed class _003COnKill_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F913")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID soundID;

		[Token(Token = "0x400F914")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudStackedKillNotificationController _0024this;

		[Token(Token = "0x600FCA6")]
		[Address(RVA = "0x1FEB9E0", Offset = "0x1FEB9E0", VA = "0x1FEB9E0")]
		public _003COnKill_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x200285D")]
	private sealed class _003COnKill_003Ec__AnonStorey1
	{
		[Token(Token = "0x400F915")]
		[FieldOffset(Offset = "0x8")]
		internal float volume;

		[Token(Token = "0x400F916")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnKill_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x600FCA7")]
		[Address(RVA = "0x1FEBDE8", Offset = "0x1FEBDE8", VA = "0x1FEBDE8")]
		public _003COnKill_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600FCA8")]
		[Address(RVA = "0x1FED848", Offset = "0x1FED848", VA = "0x1FED848")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400F8F4")]
	[FieldOffset(Offset = "0x30")]
	private UIHudStackedKillNotificationView m_View;

	[Token(Token = "0x400F8F5")]
	[FieldOffset(Offset = "0x34")]
	private float m_StackedKillShowTime;

	[Token(Token = "0x400F8F6")]
	[FieldOffset(Offset = "0x38")]
	private float m_KillKnockDownTime;

	[Token(Token = "0x400F8F7")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_ShowDelayCall;

	[Token(Token = "0x400F8F8")]
	[FieldOffset(Offset = "0x40")]
	private List<GameObject> m_StackKillList;

	[Token(Token = "0x400F8F9")]
	[FieldOffset(Offset = "0x44")]
	private string m_StackShowStateName;

	[Token(Token = "0x400F8FA")]
	[FieldOffset(Offset = "0x48")]
	private bool SettingShowStackKillIcon;

	[Token(Token = "0x400F8FB")]
	[FieldOffset(Offset = "0x49")]
	private bool CurrentShowStackKillIcon;

	[Token(Token = "0x400F8FC")]
	[FieldOffset(Offset = "0x4C")]
	private string MY_COLOR;

	[Token(Token = "0x400F8FD")]
	[FieldOffset(Offset = "0x50")]
	private string ENEMY_COLOR;

	[Token(Token = "0x400F8FE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color _BGDecorateColor_1;

	[Token(Token = "0x400F8FF")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color _BGDecorateColor_2;

	[Token(Token = "0x400F900")]
	private const float KNOCKDOWN_SHOW_DELAY = 0.5f;

	[Token(Token = "0x400F901")]
	private const float STACKKILL_SHOW_DURATION = 2f;

	[Token(Token = "0x400F902")]
	private const string STATENAME_FIRSTBLOOD = "UIHudStackedKillNotification01";

	[Token(Token = "0x400F903")]
	private const string STATENAME_DOUBLEKILL = "UIHudStackedKillNotification02";

	[Token(Token = "0x400F904")]
	private const string STATENAME_TRIPLEKILL = "UIHudStackedKillNotification03";

	[Token(Token = "0x400F905")]
	private const string STATENAME_QUADRAKILL = "UIHudStackedKillNotification04";

	[Token(Token = "0x400F906")]
	private const string STATENAME_KILL_FIVE = "UIHudStackedKillNotification05";

	[Token(Token = "0x400F907")]
	private const string STATENAME_KILL_EIGHT = "UIHudStackedKillNotification06";

	[Token(Token = "0x400F908")]
	private const string STATENAME_KILL_SIGMA = "UIHudStackedKillNotification03";

	[Token(Token = "0x400F909")]
	[FieldOffset(Offset = "0x54")]
	private List<string> mStackKillSoundRes;

	[Token(Token = "0x400F90A")]
	private const string SOUND_ACE = "SOUND_ACEKILL";

	[Token(Token = "0x400F90B")]
	private const string SOUND_AceNotification = "SOUND_AceNotification";

	[Token(Token = "0x400F90C")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<ResourceID, GameObject> m_DictVfx;

	[Token(Token = "0x400F90D")]
	[FieldOffset(Offset = "0x5C")]
	private List<string> mStackKillKey;

	[Token(Token = "0x400F90E")]
	[FieldOffset(Offset = "0x60")]
	private Player m_CurKiller;

	[Token(Token = "0x400F90F")]
	[FieldOffset(Offset = "0x64")]
	private Player m_CurBeKill;

	[Token(Token = "0x400F910")]
	[FieldOffset(Offset = "0x68")]
	private bool m_LocalPlayerOnly;

	[Token(Token = "0x400F911")]
	[FieldOffset(Offset = "0x69")]
	private bool m_3pOnly;

	[Token(Token = "0x400F912")]
	[FieldOffset(Offset = "0x6C")]
	private uint mStackedKillSoundDelayCall;

	[Token(Token = "0x600FC90")]
	[Address(RVA = "0x1FE8440", Offset = "0x1FE8440", VA = "0x1FE8440")]
	public UIHudStackedKillNotificationController()
	{
	}

	[Token(Token = "0x600FC91")]
	[Address(RVA = "0x1FE8A78", Offset = "0x1FE8A78", VA = "0x1FE8A78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC92")]
	[Address(RVA = "0x1FE8B1C", Offset = "0x1FE8B1C", VA = "0x1FE8B1C")]
	public void SetLocalPlayerOnly()
	{
	}

	[Token(Token = "0x600FC93")]
	[Address(RVA = "0x1FE8B78", Offset = "0x1FE8B78", VA = "0x1FE8B78")]
	public void Set3pOnly()
	{
	}

	[Token(Token = "0x600FC94")]
	[Address(RVA = "0x1FE8BD4", Offset = "0x1FE8BD4", VA = "0x1FE8BD4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC95")]
	[Address(RVA = "0x1FE9230", Offset = "0x1FE9230", VA = "0x1FE9230")]
	private void OnEscortBossRuinInfo(object[] data)
	{
	}

	[Token(Token = "0x600FC96")]
	[Address(RVA = "0x1FE9F58", Offset = "0x1FE9F58", VA = "0x1FE9F58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC97")]
	[Address(RVA = "0x1FEA108", Offset = "0x1FEA108", VA = "0x1FEA108", Slot = "33")]
	protected override void OnKill(Player killer, Player beKiller, object[] param)
	{
	}

	[Token(Token = "0x600FC98")]
	[Address(RVA = "0x1FEB9E8", Offset = "0x1FEB9E8", VA = "0x1FEB9E8")]
	private ResourceID getSoundResourceId(string soundIdString)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC99")]
	[Address(RVA = "0x1FEC02C", Offset = "0x1FEC02C", VA = "0x1FEC02C", Slot = "34")]
	protected override void OnTargetPlayerKill(object[] param)
	{
	}

	[Token(Token = "0x600FC9A")]
	[Address(RVA = "0x1FEC114", Offset = "0x1FEC114", VA = "0x1FEC114", Slot = "35")]
	protected override void OnKnockOtherDown(object[] param)
	{
	}

	[Token(Token = "0x600FC9B")]
	[Address(RVA = "0x1FEC870", Offset = "0x1FEC870", VA = "0x1FEC870")]
	private void OnAssistKnockDown(object[] data)
	{
	}

	[Token(Token = "0x600FC9C")]
	[Address(RVA = "0x1FEBDF0", Offset = "0x1FEBDF0", VA = "0x1FEBDF0")]
	private void DelayOrInterruptShow()
	{
	}

	[Token(Token = "0x600FC9D")]
	[Address(RVA = "0x1FECFC8", Offset = "0x1FECFC8", VA = "0x1FECFC8")]
	private void DoShowStackKill()
	{
	}

	[Token(Token = "0x600FC9E")]
	[Address(RVA = "0x1FE9C20", Offset = "0x1FE9C20", VA = "0x1FE9C20")]
	private void DoShow(float sec)
	{
	}

	[Token(Token = "0x600FC9F")]
	[Address(RVA = "0x1FED278", Offset = "0x1FED278", VA = "0x1FED278")]
	private void ShowMultiKillVfx(ResourceID resId)
	{
	}

	[Token(Token = "0x600FCA1")]
	[Address(RVA = "0x1FED80C", Offset = "0x1FED80C", VA = "0x1FED80C")]
	private void _003CDelayOrInterruptShow_003Em__0()
	{
	}

	[Token(Token = "0x600FCA2")]
	[Address(RVA = "0x1FED828", Offset = "0x1FED828", VA = "0x1FED828")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FCA3")]
	[Address(RVA = "0x1FED830", Offset = "0x1FED830", VA = "0x1FED830")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FCA4")]
	[Address(RVA = "0x1FED838", Offset = "0x1FED838", VA = "0x1FED838")]
	public void _003C_003EiFixBaseProxy_OnTargetPlayerKill(object[] P0)
	{
	}

	[Token(Token = "0x600FCA5")]
	[Address(RVA = "0x1FED840", Offset = "0x1FED840", VA = "0x1FED840")]
	public void _003C_003EiFixBaseProxy_OnKnockOtherDown(object[] P0)
	{
	}
}
