using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003494")]
public class UICupMatchCoursePageView : UIBaseView
{
	[Token(Token = "0x40147FC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UICupMatchCoursePage;

	[Token(Token = "0x40147FD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CourseTitle;

	[Token(Token = "0x40147FE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Course;

	[Token(Token = "0x40147FF")]
	[FieldOffset(Offset = "0x20")]
	public UIButton TeamTier;

	[Token(Token = "0x4014800")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TierLevel;

	[Token(Token = "0x4014801")]
	[FieldOffset(Offset = "0x28")]
	public UIButton ShowCourseBtn;

	[Token(Token = "0x4014802")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton Share;

	[Token(Token = "0x4014803")]
	[FieldOffset(Offset = "0x30")]
	public Transform CourseRewardContainer;

	[Token(Token = "0x4014804")]
	[FieldOffset(Offset = "0x34")]
	public Transform CourseresultInfo;

	[Token(Token = "0x4014805")]
	[FieldOffset(Offset = "0x38")]
	public Transform CourseInfo;

	[Token(Token = "0x4014806")]
	[FieldOffset(Offset = "0x3C")]
	public Transform ChallengeInfo;

	[Token(Token = "0x4014807")]
	[FieldOffset(Offset = "0x40")]
	public UIButton GotoChallenge;

	[Token(Token = "0x4014808")]
	[FieldOffset(Offset = "0x44")]
	public GameObject GotoChallengeTips;

	[Token(Token = "0x4014809")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ChallengeTips;

	[Token(Token = "0x401480A")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton ShowAllReward;

	[Token(Token = "0x6016170")]
	[Address(RVA = "0x274D280", Offset = "0x274D280", VA = "0x274D280")]
	public UICupMatchCoursePageView()
	{
	}

	[Token(Token = "0x6016171")]
	[Address(RVA = "0x274D288", Offset = "0x274D288", VA = "0x274D288", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016172")]
	[Address(RVA = "0x274D8AC", Offset = "0x274D8AC", VA = "0x274D8AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
