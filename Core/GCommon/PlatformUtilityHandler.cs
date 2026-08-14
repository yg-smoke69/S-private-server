using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003FAF")]
internal class PlatformUtilityHandler : MonoBehaviour
{
	[Token(Token = "0x401AD0C")]
	private const string PLATFORM_UTILITY_HANDLER = "PlatformUtilityHandler";

	[Token(Token = "0x401AD0D")]
	[FieldOffset(Offset = "0x0")]
	private static PlatformUtilityHandler _I;

	[Token(Token = "0x6019EA9")]
	[Address(RVA = "0x3315C00", Offset = "0x3315C00", VA = "0x3315C00")]
	public PlatformUtilityHandler()
	{
	}

	[Token(Token = "0x6019EAA")]
	[Address(RVA = "0x3315C08", Offset = "0x3315C08", VA = "0x3315C08")]
	public static void Init()
	{
	}

	[Token(Token = "0x6019EAB")]
	[Address(RVA = "0x3315DC0", Offset = "0x3315DC0", VA = "0x3315DC0")]
	public void OnBatteryChargingChanged(string message)
	{
	}

	[Token(Token = "0x6019EAC")]
	[Address(RVA = "0x3315E70", Offset = "0x3315E70", VA = "0x3315E70")]
	public void OnBatteryLevelChanged(string message)
	{
	}

	[Token(Token = "0x6019EAD")]
	[Address(RVA = "0x3315EF4", Offset = "0x3315EF4", VA = "0x3315EF4")]
	public void onSaveImageToAlbumResult(string error)
	{
	}

	[Token(Token = "0x6019EAE")]
	[Address(RVA = "0x3315F80", Offset = "0x3315F80", VA = "0x3315F80")]
	public void onRequestPermissionsResult(string result)
	{
	}

	[Token(Token = "0x6019EAF")]
	[Address(RVA = "0x33164C4", Offset = "0x33164C4", VA = "0x33164C4")]
	public void onAlertDialogPositiveButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EB0")]
	[Address(RVA = "0x331675C", Offset = "0x331675C", VA = "0x331675C")]
	public void onAlertDialogNegativeButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EB1")]
	[Address(RVA = "0x33169F4", Offset = "0x33169F4", VA = "0x33169F4")]
	public void onAlertDialogNeutralButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EB2")]
	[Address(RVA = "0x3316C8C", Offset = "0x3316C8C", VA = "0x3316C8C")]
	public void onGetAdvertisingId(string result)
	{
	}

	[Token(Token = "0x6019EB3")]
	[Address(RVA = "0x3316F88", Offset = "0x3316F88", VA = "0x3316F88")]
	public void onInAppReviewCallback(string result)
	{
	}

	[Token(Token = "0x6019EB4")]
	[Address(RVA = "0x3317284", Offset = "0x3317284", VA = "0x3317284")]
	public void onTakenScreenshot(string clue)
	{
	}
}
