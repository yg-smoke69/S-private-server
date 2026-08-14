using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200404D")]
public class VibrateManager : MonoBehaviour
{
	[Token(Token = "0x401B0FD")]
	[FieldOffset(Offset = "0x0")]
	private static VibrateManager m_Instance;

	[Token(Token = "0x401B0FE")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, long[]> vibrateInfoDic;

	[Token(Token = "0x17001CB5")]
	public static VibrateManager instance
	{
		[Token(Token = "0x601A2B3")]
		[Address(RVA = "0x2BD5998", Offset = "0x2BD5998", VA = "0x2BD5998")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A2B2")]
	[Address(RVA = "0x2BD5990", Offset = "0x2BD5990", VA = "0x2BD5990")]
	public VibrateManager()
	{
	}

	[Token(Token = "0x601A2B4")]
	[Address(RVA = "0x2BD5A24", Offset = "0x2BD5A24", VA = "0x2BD5A24")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A2B5")]
	[Address(RVA = "0x2BD5AB4", Offset = "0x2BD5AB4", VA = "0x2BD5AB4")]
	private void Start()
	{
	}

	[Token(Token = "0x601A2B6")]
	[Address(RVA = "0x2BD5AB8", Offset = "0x2BD5AB8", VA = "0x2BD5AB8")]
	private void InitVibrateInfo()
	{
	}

	[Token(Token = "0x601A2B7")]
	[Address(RVA = "0x2BD5E08", Offset = "0x2BD5E08", VA = "0x2BD5E08")]
	public void StartVibrate(VibrateStyle _vibrateStyle, bool _IsLoop = false)
	{
	}

	[Token(Token = "0x601A2B8")]
	[Address(RVA = "0x2BD5FD4", Offset = "0x2BD5FD4", VA = "0x2BD5FD4")]
	public void StopVibrate()
	{
	}

	[Token(Token = "0x601A2B9")]
	[Address(RVA = "0x2BD5F08", Offset = "0x2BD5F08", VA = "0x2BD5F08")]
	private bool isVibrateSupported()
	{
		return default(bool);
	}

	[Token(Token = "0x601A2BA")]
	[Address(RVA = "0x2BD5FD8", Offset = "0x2BD5FD8", VA = "0x2BD5FD8")]
	public bool isAsusRogPhone()
	{
		return default(bool);
	}
}
