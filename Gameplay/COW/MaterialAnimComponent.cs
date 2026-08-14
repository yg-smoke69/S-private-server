using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E76")]
public class MaterialAnimComponent : MonoBehaviour
{
	[Token(Token = "0x2001E77")]
	public class MonoBehaviourWithWardrobeType
	{
		[Token(Token = "0x400BF93")]
		[FieldOffset(Offset = "0x8")]
		public MonoBehaviour m_Behaviours;

		[Token(Token = "0x400BF94")]
		[FieldOffset(Offset = "0xC")]
		public int m_Type;

		[Token(Token = "0x600929A")]
		[Address(RVA = "0x1545E5C", Offset = "0x1545E5C", VA = "0x1545E5C")]
		public MonoBehaviourWithWardrobeType()
		{
		}
	}

	[Token(Token = "0x400BF90")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<int, MaterialRef> m_MaterialRefs;

	[Token(Token = "0x400BF91")]
	[FieldOffset(Offset = "0x10")]
	private List<MonoBehaviourWithWardrobeType> m_Behaviours;

	[Token(Token = "0x400BF92")]
	[FieldOffset(Offset = "0x14")]
	private Renderer m_Renderer;

	[Token(Token = "0x6009291")]
	[Address(RVA = "0x1544AF8", Offset = "0x1544AF8", VA = "0x1544AF8")]
	public MaterialAnimComponent()
	{
	}

	[Token(Token = "0x6009292")]
	[Address(RVA = "0x1544BB8", Offset = "0x1544BB8", VA = "0x1544BB8")]
	public void AddTargets(int type, MaterialRef matRef)
	{
	}

	[Token(Token = "0x6009293")]
	[Address(RVA = "0x1544D44", Offset = "0x1544D44", VA = "0x1544D44")]
	private void FindUMARenderer()
	{
	}

	[Token(Token = "0x6009294")]
	[Address(RVA = "0x1544F04", Offset = "0x1544F04", VA = "0x1544F04")]
	public void StopAnim()
	{
	}

	[Token(Token = "0x6009295")]
	[Address(RVA = "0x15450FC", Offset = "0x15450FC", VA = "0x15450FC")]
	public void StopAnim(int type)
	{
	}

	[Token(Token = "0x6009296")]
	[Address(RVA = "0x15452A4", Offset = "0x15452A4", VA = "0x15452A4")]
	public void ShowAnim(int type)
	{
	}

	[Token(Token = "0x6009297")]
	[Address(RVA = "0x1545490", Offset = "0x1545490", VA = "0x1545490")]
	private void AddTargetComponent(int type, MaterialRef materialRef, Material[] mats)
	{
	}

	[Token(Token = "0x6009298")]
	[Address(RVA = "0x1545E64", Offset = "0x1545E64", VA = "0x1545E64")]
	public void ShowAnim()
	{
	}

	[Token(Token = "0x6009299")]
	[Address(RVA = "0x1545B64", Offset = "0x1545B64", VA = "0x1545B64")]
	private bool FindMatchedMaterial(Material[] mats, PropertyRecorder item, out Material mat, out int materialIndex)
	{
		return default(bool);
	}
}
