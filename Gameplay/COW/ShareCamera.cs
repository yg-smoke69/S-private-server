using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A92")]
public class ShareCamera : MonoBehaviour
{
	[Token(Token = "0x2003A93")]
	public delegate void AfterRender();

	[Token(Token = "0x4018E90")]
	[FieldOffset(Offset = "0xC")]
	private bool RenderFlag;

	[Token(Token = "0x4018E91")]
	[FieldOffset(Offset = "0x10")]
	private Camera ShareCam;

	[Token(Token = "0x4018E92")]
	[FieldOffset(Offset = "0x14")]
	private AfterRender m_AfterRenderCallBack;

	[Token(Token = "0x4018E93")]
	[FieldOffset(Offset = "0x18")]
	private int delayCall;

	[Token(Token = "0x601735C")]
	[Address(RVA = "0x20E4FA0", Offset = "0x20E4FA0", VA = "0x20E4FA0")]
	public ShareCamera()
	{
	}

	[Token(Token = "0x601735D")]
	[Address(RVA = "0x20E4FA8", Offset = "0x20E4FA8", VA = "0x20E4FA8")]
	public void RenderScreenshot(RenderTexture rt, AfterRender callback)
	{
	}

	[Token(Token = "0x601735E")]
	[Address(RVA = "0x20E510C", Offset = "0x20E510C", VA = "0x20E510C")]
	private void OnPostRender()
	{
	}
}
