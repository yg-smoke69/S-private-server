using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045E")]
public class LevelRendererManager : MonoBehaviour
{
	[Token(Token = "0x4003CB3")]
	[FieldOffset(Offset = "0xC")]
	public int LevelID;

	[Token(Token = "0x4003CB4")]
	[FieldOffset(Offset = "0x10")]
	public List<Renderer> Renderers;

	[Token(Token = "0x4003CB5")]
	[FieldOffset(Offset = "0x14")]
	private bool m_Inited;

	[Token(Token = "0x4003CB6")]
	[FieldOffset(Offset = "0x15")]
	private bool m_IsVisible;

	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x3115FE4", Offset = "0x3115FE4", VA = "0x3115FE4")]
	public LevelRendererManager()
	{
	}

	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x3116070", Offset = "0x3116070", VA = "0x3116070")]
	private void Start()
	{
	}

	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x3116168", Offset = "0x3116168", VA = "0x3116168")]
	public void SetRenderVisible(bool isVisible)
	{
	}
}
