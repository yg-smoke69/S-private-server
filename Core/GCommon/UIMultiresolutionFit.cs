using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200415B")]
public class UIMultiresolutionFit : MonoBehaviour
{
	[Token(Token = "0x401B6B6")]
	[FieldOffset(Offset = "0xC")]
	public int sourceAspectWidth;

	[Token(Token = "0x401B6B7")]
	[FieldOffset(Offset = "0x10")]
	public int sourceAspectHight;

	[Token(Token = "0x401B6B8")]
	[FieldOffset(Offset = "0x14")]
	public bool showTop;

	[Token(Token = "0x401B6B9")]
	[FieldOffset(Offset = "0x18")]
	private float sourceAspect;

	[Token(Token = "0x401B6BA")]
	[FieldOffset(Offset = "0x1C")]
	private bool baseOnWidth;

	[Token(Token = "0x401B6BB")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget widget;

	[Token(Token = "0x401B6BC")]
	[FieldOffset(Offset = "0x24")]
	private bool init;

	[Token(Token = "0x401B6BD")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 screenSize;

	[Token(Token = "0x401B6BE")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 fullScreenNguiSize;

	[Token(Token = "0x401B6BF")]
	[FieldOffset(Offset = "0x38")]
	private UIRoot uiRoot;

	[Token(Token = "0x401B6C0")]
	[FieldOffset(Offset = "0x3C")]
	private float lastScreenRatio;

	[Token(Token = "0x401B6C1")]
	[FieldOffset(Offset = "0x40")]
	private int lastUIRootWidth;

	[Token(Token = "0x601AB2C")]
	[Address(RVA = "0x2CA931C", Offset = "0x2CA931C", VA = "0x2CA931C")]
	public UIMultiresolutionFit()
	{
	}

	[Token(Token = "0x601AB2D")]
	[Address(RVA = "0x2CA9338", Offset = "0x2CA9338", VA = "0x2CA9338")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AB2E")]
	[Address(RVA = "0x2CA933C", Offset = "0x2CA933C", VA = "0x2CA933C")]
	private void Start()
	{
	}

	[Token(Token = "0x601AB2F")]
	[Address(RVA = "0x2CA9358", Offset = "0x2CA9358", VA = "0x2CA9358")]
	private void Init()
	{
	}

	[Token(Token = "0x601AB30")]
	[Address(RVA = "0x2CA9910", Offset = "0x2CA9910", VA = "0x2CA9910")]
	private void OnUIRootChange()
	{
	}

	[Token(Token = "0x601AB31")]
	[Address(RVA = "0x2CA975C", Offset = "0x2CA975C", VA = "0x2CA975C")]
	private void CalcFullScreenNguiSize()
	{
	}

	[Token(Token = "0x601AB32")]
	[Address(RVA = "0x2CA9A0C", Offset = "0x2CA9A0C", VA = "0x2CA9A0C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601AB33")]
	[Address(RVA = "0x2CA9520", Offset = "0x2CA9520", VA = "0x2CA9520")]
	public void FitSize()
	{
	}
}
