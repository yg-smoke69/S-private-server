using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace COW;

[Token(Token = "0x2000280")]
public class COWGameEntry : MonoBehaviour
{
	[Token(Token = "0x2000281")]
	private sealed class _003CEnterFrontEndGame_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x8")]
		internal Scene scene;

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x181F61C", Offset = "0x181F61C", VA = "0x181F61C")]
		public _003CEnterFrontEndGame_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x181FCA8", Offset = "0x181FCA8", VA = "0x181FCA8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0xC")]
	private GameEngine m_GameEngine;

	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0x10")]
	private UIPopupMessageBoxController m_QuitDialog;

	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CPaused_003Ek__BackingField;

	[Token(Token = "0x4000F32")]
	[FieldOffset(Offset = "0x0")]
	private static PlatformUtility.LogCallback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4000F33")]
	[FieldOffset(Offset = "0x4")]
	private static PlatformUtility.LogCallback _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0x8")]
	private static Action<string> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0xC")]
	private static Action<string> _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x17000174")]
	public bool Paused
	{
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x1816360", Offset = "0x1816360", VA = "0x1816360")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x1816368", Offset = "0x1816368", VA = "0x1816368")]
		set
		{
		}
	}

	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x1816358", Offset = "0x1816358", VA = "0x1816358")]
	public COWGameEntry()
	{
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x1816370", Offset = "0x1816370", VA = "0x1816370")]
	public static void SwitchSkinnedCompress()
	{
	}

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x18165CC", Offset = "0x18165CC", VA = "0x18165CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x181CFD0", Offset = "0x181CFD0", VA = "0x181CFD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x181DBA0", Offset = "0x181DBA0", VA = "0x181DBA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x181E508", Offset = "0x181E508", VA = "0x181E508")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x181E58C", Offset = "0x181E58C", VA = "0x181E58C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x181E8C8", Offset = "0x181E8C8", VA = "0x181E8C8")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x181EFB8", Offset = "0x181EFB8", VA = "0x181EFB8")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x181F090", Offset = "0x181F090", VA = "0x181F090")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x181F3B0", Offset = "0x181F3B0", VA = "0x181F3B0")]
	public string GetVersionString()
	{
		return null;
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x181F4A4", Offset = "0x181F4A4", VA = "0x181F4A4")]
	public void Restart()
	{
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x181DA44", Offset = "0x181DA44", VA = "0x181DA44")]
	private void EnterFrontEndGame()
	{
	}

	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x1817A1C", Offset = "0x1817A1C", VA = "0x1817A1C")]
	private void RefreshConfigData()
	{
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x181F624", Offset = "0x181F624", VA = "0x181F624")]
	private void ReplaceClothesForHD()
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x181C704", Offset = "0x181C704", VA = "0x181C704")]
	private void RefreshPrezEnable()
	{
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x181DE98", Offset = "0x181DE98", VA = "0x181DE98")]
	private void HandleBackButton()
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x181FC8C", Offset = "0x181FC8C", VA = "0x181FC8C")]
	private void _003CHandleBackButton_003Em__0()
	{
	}

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x181FC9C", Offset = "0x181FC9C", VA = "0x181FC9C")]
	private void _003CHandleBackButton_003Em__1()
	{
	}
}
