using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000A8F")]
public class SceneRendererGroup : MonoBehaviour
{
	[Token(Token = "0x4005CC4")]
	[FieldOffset(Offset = "0xC")]
	public BIFDEFBNCDK GroupType;

	[Token(Token = "0x4005CC5")]
	[FieldOffset(Offset = "0x10")]
	public List<Renderer> RendererList;

	[Token(Token = "0x4005CC6")]
	[FieldOffset(Offset = "0x14")]
	private bool MLIAEPENEFD;

	[Token(Token = "0x6005119")]
	[Address(RVA = "0x1D71B50", Offset = "0x1D71B50", VA = "0x1D71B50")]
	public SceneRendererGroup()
	{
	}

	[Token(Token = "0x600511A")]
	[Address(RVA = "0x1D71BE4", Offset = "0x1D71BE4", VA = "0x1D71BE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600511B")]
	[Address(RVA = "0x1D71DE4", Offset = "0x1D71DE4", VA = "0x1D71DE4")]
	public void RefreshRendererlist()
	{
	}

	[Token(Token = "0x600511C")]
	[Address(RVA = "0x1D71E38", Offset = "0x1D71E38", VA = "0x1D71E38")]
	public void ApplyGroupFlag(uint EBOJJLIHHCM)
	{
	}
}
