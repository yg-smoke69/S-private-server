using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004028")]
internal class UnityWebViewHandler : MonoBehaviour
{
	[Token(Token = "0x2004029")]
	private sealed class _003CForceCloseAll_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B003")]
		[FieldOffset(Offset = "0x8")]
		internal string msg;

		[Token(Token = "0x601A227")]
		[Address(RVA = "0x2BCCE80", Offset = "0x2BCCE80", VA = "0x2BCCE80")]
		public _003CForceCloseAll_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A228")]
		[Address(RVA = "0x2BCCE88", Offset = "0x2BCCE88", VA = "0x2BCCE88")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B001")]
	private const string UNITY_WEBVIEW_HANDLER = "UnityWebViewHandler";

	[Token(Token = "0x401B002")]
	[FieldOffset(Offset = "0x0")]
	private static UnityWebViewHandler _I;

	[Token(Token = "0x601A222")]
	[Address(RVA = "0x2BCCB10", Offset = "0x2BCCB10", VA = "0x2BCCB10")]
	public UnityWebViewHandler()
	{
	}

	[Token(Token = "0x601A223")]
	[Address(RVA = "0x2BC5490", Offset = "0x2BC5490", VA = "0x2BC5490")]
	public static void Init()
	{
	}

	[Token(Token = "0x601A224")]
	[Address(RVA = "0x2BCCB18", Offset = "0x2BCCB18", VA = "0x2BCCB18")]
	public void OnWebViewMessage_Android(string msg)
	{
	}

	[Token(Token = "0x601A225")]
	[Address(RVA = "0x2BCCBE4", Offset = "0x2BCCBE4", VA = "0x2BCCBE4")]
	public void testResult(string result)
	{
	}

	[Token(Token = "0x601A226")]
	[Address(RVA = "0x2BCCD90", Offset = "0x2BCCD90", VA = "0x2BCCD90")]
	public void ForceCloseAll(string msg)
	{
	}
}
