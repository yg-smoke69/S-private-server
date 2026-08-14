using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200290B")]
internal class UILoadingController : MonoBehaviour
{
	[Token(Token = "0x200290C")]
	private sealed class _003CRefreshLoadingBg_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FCCD")]
		[FieldOffset(Offset = "0x8")]
		internal Vector2 fitSize;

		[Token(Token = "0x400FCCE")]
		[FieldOffset(Offset = "0x10")]
		internal UILoadingController _0024this;

		[Token(Token = "0x6010465")]
		[Address(RVA = "0x2158684", Offset = "0x2158684", VA = "0x2158684")]
		public _003CRefreshLoadingBg_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010466")]
		[Address(RVA = "0x2158DBC", Offset = "0x2158DBC", VA = "0x2158DBC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200290D")]
	private sealed class _003CGetCdnUrlByGameMode_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FCCF")]
		[FieldOffset(Offset = "0x8")]
		internal bool gamemodeNoneFilter;

		[Token(Token = "0x6010467")]
		[Address(RVA = "0x2158970", Offset = "0x2158970", VA = "0x2158970")]
		public _003CGetCdnUrlByGameMode_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010468")]
		[Address(RVA = "0x2158D10", Offset = "0x2158D10", VA = "0x2158D10")]
		internal bool _003C_003Em__0(AdvertDesc v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FCC2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel m_Tips;

	[Token(Token = "0x400FCC3")]
	[FieldOffset(Offset = "0x10")]
	public UIProgressBar m_ProgressBar;

	[Token(Token = "0x400FCC4")]
	[FieldOffset(Offset = "0x14")]
	public UITexture m_BG;

	[Token(Token = "0x400FCC5")]
	[FieldOffset(Offset = "0x18")]
	private float m_Progress;

	[Token(Token = "0x400FCC6")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Logo;

	[Token(Token = "0x400FCC7")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid m_GridPlayerInfo;

	[Token(Token = "0x400FCC8")]
	[FieldOffset(Offset = "0x24")]
	public Transform m_RootPlayerInfoTip;

	[Token(Token = "0x400FCC9")]
	[FieldOffset(Offset = "0x28")]
	private float m_OpenTime;

	[Token(Token = "0x400FCCA")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_AchieveTimeLengthCanClose;

	[Token(Token = "0x400FCCB")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_TriggerCanDestroy;

	[Token(Token = "0x400FCCC")]
	[FieldOffset(Offset = "0x2E")]
	private bool m_TriggerNeedUnloadAsset;

	[Token(Token = "0x6010457")]
	[Address(RVA = "0x21564E0", Offset = "0x21564E0", VA = "0x21564E0")]
	public UILoadingController()
	{
	}

	[Token(Token = "0x6010458")]
	[Address(RVA = "0x21564E8", Offset = "0x21564E8", VA = "0x21564E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6010459")]
	[Address(RVA = "0x215794C", Offset = "0x215794C", VA = "0x215794C")]
	private void Start()
	{
	}

	[Token(Token = "0x601045A")]
	[Address(RVA = "0x2157BE8", Offset = "0x2157BE8", VA = "0x2157BE8")]
	private void Update()
	{
	}

	[Token(Token = "0x601045B")]
	[Address(RVA = "0x2158218", Offset = "0x2158218", VA = "0x2158218")]
	public void TriggerCanDestroy()
	{
	}

	[Token(Token = "0x601045C")]
	[Address(RVA = "0x2158274", Offset = "0x2158274", VA = "0x2158274")]
	public void TriggerNeedUnloadAsset()
	{
	}

	[Token(Token = "0x601045D")]
	[Address(RVA = "0x2157FF4", Offset = "0x2157FF4", VA = "0x2157FF4")]
	private void CheckCanDestroy()
	{
	}

	[Token(Token = "0x601045E")]
	[Address(RVA = "0x21582D0", Offset = "0x21582D0", VA = "0x21582D0")]
	private void DestroySelf()
	{
	}

	[Token(Token = "0x601045F")]
	[Address(RVA = "0x21584E4", Offset = "0x21584E4", VA = "0x21584E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6010460")]
	[Address(RVA = "0x2157D04", Offset = "0x2157D04", VA = "0x2157D04")]
	private void RefreshProgressBar()
	{
	}

	[Token(Token = "0x6010461")]
	[Address(RVA = "0x2156D78", Offset = "0x2156D78", VA = "0x2156D78")]
	private void RefreshLoadingBg()
	{
	}

	[Token(Token = "0x6010462")]
	[Address(RVA = "0x215868C", Offset = "0x215868C", VA = "0x215868C")]
	private string GetCdnUrlByGameMode(bool gamemodeNoneFilter = false)
	{
		return null;
	}

	[Token(Token = "0x6010463")]
	[Address(RVA = "0x2157368", Offset = "0x2157368", VA = "0x2157368")]
	private bool CheckNeedShowPlayerInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6010464")]
	[Address(RVA = "0x2157440", Offset = "0x2157440", VA = "0x2157440")]
	private void RefreshPlayerInfo()
	{
	}
}
