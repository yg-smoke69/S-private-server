using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004128")]
public class UIBaseView
{
	[Token(Token = "0x401B5D8")]
	[FieldOffset(Offset = "0x8")]
	protected Vector2 m_WindowsSize;

	[Token(Token = "0x401B5D9")]
	[FieldOffset(Offset = "0x10")]
	private bool m_FullScreenUI;

	[Token(Token = "0x17001D57")]
	public Vector2 WindowsSize
	{
		[Token(Token = "0x601AA13")]
		[Address(RVA = "0x2C9B3EC", Offset = "0x2C9B3EC", VA = "0x2C9B3EC")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001D58")]
	public bool FullScreenUI
	{
		[Token(Token = "0x601AA14")]
		[Address(RVA = "0x2C9B400", Offset = "0x2C9B400", VA = "0x2C9B400")]
		set
		{
		}
	}

	[Token(Token = "0x601AA12")]
	[Address(RVA = "0x2C9B3E4", Offset = "0x2C9B3E4", VA = "0x2C9B3E4")]
	public UIBaseView()
	{
	}

	[Token(Token = "0x601AA15")]
	[Address(RVA = "0x2C9B408", Offset = "0x2C9B408", VA = "0x2C9B408")]
	public void Init(Transform rootTrans, Transform holder)
	{
	}

	[Token(Token = "0x601AA16")]
	[Address(RVA = "0x2C9B758", Offset = "0x2C9B758", VA = "0x2C9B758", Slot = "4")]
	protected virtual void OnInit(Transform holder)
	{
	}
}
