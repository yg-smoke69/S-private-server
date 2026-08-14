using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000083")]
public class AppsFlyerObject : MonoBehaviour
{
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x0")]
	private static AppsFlyerObject _003CInstance_003Ek__BackingField;

	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x10")]
	public TimeSpan LocalRegistrationTime;

	[Token(Token = "0x1700006C")]
	public static AppsFlyerObject Instance
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x14CB2BC", Offset = "0x14CB2BC", VA = "0x14CB2BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x14CB320", Offset = "0x14CB320", VA = "0x14CB320")]
		private set
		{
		}
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x14CB2B4", Offset = "0x14CB2B4", VA = "0x14CB2B4")]
	public AppsFlyerObject()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x14CB384", Offset = "0x14CB384", VA = "0x14CB384")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x14CB5BC", Offset = "0x14CB5BC", VA = "0x14CB5BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x14CB830", Offset = "0x14CB830", VA = "0x14CB830")]
	private void HandleLog(string logString, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x14CB8A4", Offset = "0x14CB8A4", VA = "0x14CB8A4")]
	public void didReceiveConversionData(string conversionData)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x14CB9C4", Offset = "0x14CB9C4", VA = "0x14CB9C4")]
	public void didReceiveConversionDataWithError(string error)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x14CBAE4", Offset = "0x14CBAE4", VA = "0x14CBAE4")]
	public void onAppOpenAttribution(string validateResult)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x14CBC04", Offset = "0x14CBC04", VA = "0x14CBC04")]
	public void onAppOpenAttributionFailure(string error)
	{
	}
}
