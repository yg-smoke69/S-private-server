using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003ADF")]
public class GameStartup : MonoBehaviour
{
	[Token(Token = "0x2003AE0")]
	public enum EGameServerAddress
	{
		[Token(Token = "0x4019123")]
		LOCAL_SERVER,
		[Token(Token = "0x4019124")]
		SBT_SERVER,
		[Token(Token = "0x4019125")]
		RCT_SERVER,
		[Token(Token = "0x4019126")]
		DS1_SERVER,
		[Token(Token = "0x4019127")]
		DS2_SERVER,
		[Token(Token = "0x4019128")]
		DS3_SERVER,
		[Token(Token = "0x4019129")]
		ACT01_SERVER,
		[Token(Token = "0x401912A")]
		REVIEW_SERVER
	}

	[Token(Token = "0x2003AE1")]
	private sealed class _003CStartLauncher_003Ec__AnonStorey0
	{
		[Token(Token = "0x401912B")]
		[FieldOffset(Offset = "0x8")]
		internal bool isRestart;

		[Token(Token = "0x401912C")]
		[FieldOffset(Offset = "0xC")]
		internal GameStartup _0024this;

		[Token(Token = "0x60175E9")]
		[Address(RVA = "0x2491900", Offset = "0x2491900", VA = "0x2491900")]
		public _003CStartLauncher_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60175EA")]
		[Address(RVA = "0x24926F8", Offset = "0x24926F8", VA = "0x24926F8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x60175EB")]
		[Address(RVA = "0x24929E0", Offset = "0x24929E0", VA = "0x24929E0")]
		internal UIBaseController _003C_003Em__1(string path, Type type)
		{
			return null;
		}
	}

	[Token(Token = "0x401910E")]
	[FieldOffset(Offset = "0x0")]
	public static GameStartup instance;

	[Token(Token = "0x401910F")]
	[FieldOffset(Offset = "0xC")]
	private bool m_IsEnterGame;

	[Token(Token = "0x4019110")]
	[FieldOffset(Offset = "0xD")]
	public bool UseAssetBundle;

	[Token(Token = "0x4019111")]
	[FieldOffset(Offset = "0xE")]
	public bool MuteSound;

	[Token(Token = "0x4019112")]
	[FieldOffset(Offset = "0x10")]
	public string DevId;

	[Token(Token = "0x4019113")]
	[FieldOffset(Offset = "0x14")]
	public bool ShowDebugInfo;

	[Token(Token = "0x4019114")]
	[FieldOffset(Offset = "0x18")]
	public EGameServerAddress m_gameServer;

	[Token(Token = "0x4019115")]
	[FieldOffset(Offset = "0x1C")]
	public string CDNAddr;

	[Token(Token = "0x4019116")]
	[FieldOffset(Offset = "0x20")]
	public string VerAddr;

	[Token(Token = "0x4019117")]
	[FieldOffset(Offset = "0x24")]
	public string GatewayAddr;

	[Token(Token = "0x4019118")]
	[FieldOffset(Offset = "0x28")]
	public bool SkipVersionCheck;

	[Token(Token = "0x4019119")]
	[FieldOffset(Offset = "0x29")]
	public bool ShowTutorial;

	[Token(Token = "0x401911A")]
	[FieldOffset(Offset = "0x2C")]
	public ShaderVariantCollection ShaderCollection;

	[Token(Token = "0x401911B")]
	[FieldOffset(Offset = "0x30")]
	private COWGameEntry m_MainEntry;

	[Token(Token = "0x401911C")]
	[FieldOffset(Offset = "0x34")]
	private UILauncherController m_LaucherController;

	[Token(Token = "0x401911D")]
	private const string PLAYER_PREF_KEY_LANGUAGE_CHECK_FLAG = "CHECK_AND_ADJUST_LANGUAGE_FLAG";

	[Token(Token = "0x401911E")]
	[FieldOffset(Offset = "0x38")]
	private readonly string[] DONT_DESTROY_RESOURCES;

	[Token(Token = "0x401911F")]
	[FieldOffset(Offset = "0x4")]
	private static OnLogCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019120")]
	[FieldOffset(Offset = "0x8")]
	private static Action<string, string> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4019121")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x170017B7")]
	private string LocalLanguageCheckFlag
	{
		[Token(Token = "0x60175DA")]
		[Address(RVA = "0x24903E4", Offset = "0x24903E4", VA = "0x24903E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60175DB")]
		[Address(RVA = "0x24904C4", Offset = "0x24904C4", VA = "0x24904C4")]
		set
		{
		}
	}

	[Token(Token = "0x170017B8")]
	private string RemoteLanguageCheckFlag
	{
		[Token(Token = "0x60175DC")]
		[Address(RVA = "0x24905AC", Offset = "0x24905AC", VA = "0x24905AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60175D4")]
	[Address(RVA = "0x248F89C", Offset = "0x248F89C", VA = "0x248F89C")]
	public GameStartup()
	{
	}

	[Token(Token = "0x60175D5")]
	[Address(RVA = "0x248FA24", Offset = "0x248FA24", VA = "0x248FA24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60175D6")]
	[Address(RVA = "0x248FFF4", Offset = "0x248FFF4", VA = "0x248FFF4")]
	private void Start()
	{
	}

	[Token(Token = "0x60175D7")]
	[Address(RVA = "0x24901BC", Offset = "0x24901BC", VA = "0x24901BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60175D8")]
	[Address(RVA = "0x2490240", Offset = "0x2490240", VA = "0x2490240")]
	public void Quit(string str)
	{
	}

	[Token(Token = "0x60175D9")]
	[Address(RVA = "0x24902A8", Offset = "0x24902A8", VA = "0x24902A8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60175DD")]
	[Address(RVA = "0x2490734", Offset = "0x2490734", VA = "0x2490734")]
	private void CheckAndAdjustLanguage()
	{
	}

	[Token(Token = "0x60175DE")]
	[Address(RVA = "0x2490A74", Offset = "0x2490A74", VA = "0x2490A74")]
	public void StartGame()
	{
	}

	[Token(Token = "0x60175DF")]
	[Address(RVA = "0x2491534", Offset = "0x2491534", VA = "0x2491534")]
	public void Restart()
	{
	}

	[Token(Token = "0x60175E0")]
	[Address(RVA = "0x24917FC", Offset = "0x24917FC", VA = "0x24917FC")]
	public void CloseLauncher()
	{
	}

	[Token(Token = "0x60175E1")]
	[Address(RVA = "0x2491270", Offset = "0x2491270", VA = "0x2491270")]
	public void StartLauncher(bool isRestart)
	{
	}

	[Token(Token = "0x60175E2")]
	[Address(RVA = "0x2491908", Offset = "0x2491908", VA = "0x2491908")]
	private void LaunchGame(bool isSoftRestart)
	{
	}

	[Token(Token = "0x60175E3")]
	[Address(RVA = "0x24920E8", Offset = "0x24920E8", VA = "0x24920E8")]
	public void GetConfigServerData()
	{
	}

	[Token(Token = "0x60175E4")]
	private T CreateUI<T>(Transform root, string path) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x60175E5")]
	[Address(RVA = "0x2492238", Offset = "0x2492238", VA = "0x2492238")]
	private UIBaseController CreateUI(Transform root, string path, Type classType)
	{
		return null;
	}

	[Token(Token = "0x60175E7")]
	[Address(RVA = "0x2492568", Offset = "0x2492568", VA = "0x2492568")]
	private static void _003CAwake_003Em__0(DebugLogType logType, string content)
	{
	}

	[Token(Token = "0x60175E8")]
	[Address(RVA = "0x249263C", Offset = "0x249263C", VA = "0x249263C")]
	private void _003CStart_003Em__1(Dictionary<int, bool> result)
	{
	}
}
