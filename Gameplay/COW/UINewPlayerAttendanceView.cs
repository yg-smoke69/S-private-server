using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C2")]
public class UINewPlayerAttendanceView : UIBaseView
{
	[Token(Token = "0x401782A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AttendanceRewardButton;

	[Token(Token = "0x401782B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject AttendanceBg;

	[Token(Token = "0x401782C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject AttendanceChooseBg;

	[Token(Token = "0x401782D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite AttendanceWeapon;

	[Token(Token = "0x401782E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel AttendanceCount;

	[Token(Token = "0x401782F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel AttendanceTime;

	[Token(Token = "0x4017830")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AttendanceRewardIcon;

	[Token(Token = "0x4017831")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AttendanceLabel;

	[Token(Token = "0x4017832")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AttendanceClaimedIcon;

	[Token(Token = "0x4017833")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AttendanceNormal;

	[Token(Token = "0x4017834")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AttendanceLocked;

	[Token(Token = "0x4017835")]
	[FieldOffset(Offset = "0x40")]
	public UILabel AttendanceButtonLabel;

	[Token(Token = "0x4017836")]
	[FieldOffset(Offset = "0x44")]
	public UIButton AttendanceButton;

	[Token(Token = "0x4017837")]
	[FieldOffset(Offset = "0x48")]
	public UIButton MissionTodayRewardButton;

	[Token(Token = "0x4017838")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite MissionTodayRewardIcon;

	[Token(Token = "0x4017839")]
	[FieldOffset(Offset = "0x50")]
	public GameObject MissionTodayBg;

	[Token(Token = "0x401783A")]
	[FieldOffset(Offset = "0x54")]
	public GameObject MissionTodayChooseBg;

	[Token(Token = "0x401783B")]
	[FieldOffset(Offset = "0x58")]
	public UISprite MissionTodayWeapon;

	[Token(Token = "0x401783C")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel MissionTodayCount;

	[Token(Token = "0x401783D")]
	[FieldOffset(Offset = "0x60")]
	public UILabel MissionTodayTime;

	[Token(Token = "0x401783E")]
	[FieldOffset(Offset = "0x64")]
	public UILabel MissionTodayLabel;

	[Token(Token = "0x401783F")]
	[FieldOffset(Offset = "0x68")]
	public GameObject MissionTodayClaimedIcon;

	[Token(Token = "0x4017840")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject MissionTodayNormal;

	[Token(Token = "0x4017841")]
	[FieldOffset(Offset = "0x70")]
	public UILabel MissionTodayProgress;

	[Token(Token = "0x4017842")]
	[FieldOffset(Offset = "0x74")]
	public GameObject MissionTodayLocked;

	[Token(Token = "0x4017843")]
	[FieldOffset(Offset = "0x78")]
	public UIGrid MissionGrid;

	[Token(Token = "0x4017844")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel MissionTodayButtonLabel;

	[Token(Token = "0x4017845")]
	[FieldOffset(Offset = "0x80")]
	public UIButton MissionTodayButton;

	[Token(Token = "0x4017846")]
	[FieldOffset(Offset = "0x84")]
	public GameObject AttendanceSign;

	[Token(Token = "0x4017847")]
	[FieldOffset(Offset = "0x88")]
	public GameObject MissionSign;

	[Token(Token = "0x4017848")]
	[FieldOffset(Offset = "0x8C")]
	public Animation mian;

	[Token(Token = "0x4017849")]
	[FieldOffset(Offset = "0x90")]
	public Animation miann;

	[Token(Token = "0x6016DF1")]
	[Address(RVA = "0x27A9E5C", Offset = "0x27A9E5C", VA = "0x27A9E5C")]
	public UINewPlayerAttendanceView()
	{
	}

	[Token(Token = "0x6016DF2")]
	[Address(RVA = "0x27A9E64", Offset = "0x27A9E64", VA = "0x27A9E64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DF3")]
	[Address(RVA = "0x27AAB1C", Offset = "0x27AAB1C", VA = "0x27AAB1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
