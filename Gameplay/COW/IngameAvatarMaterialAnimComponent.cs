using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200040E")]
public class IngameAvatarMaterialAnimComponent : MonoBehaviour
{
	[Token(Token = "0x200040F")]
	public class MonoBehaviourWithWardrobeType
	{
		[Token(Token = "0x4003AE4")]
		[FieldOffset(Offset = "0x8")]
		public MonoBehaviour m_Behaviours;

		[Token(Token = "0x4003AE5")]
		[FieldOffset(Offset = "0xC")]
		public UIModelAvatarBase.EWardrobeType m_Type;

		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x2C7EFDC", Offset = "0x2C7EFDC", VA = "0x2C7EFDC")]
		public MonoBehaviourWithWardrobeType()
		{
		}
	}

	[Token(Token = "0x4003AE0")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<int> m_HoldOnType;

	[Token(Token = "0x4003AE1")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<int, MaterialRef> m_MaterialRefs;

	[Token(Token = "0x4003AE2")]
	[FieldOffset(Offset = "0x14")]
	private List<MonoBehaviourWithWardrobeType> m_Behaviours;

	[Token(Token = "0x4003AE3")]
	[FieldOffset(Offset = "0x18")]
	private Renderer m_Renderer;

	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x2C7DD4C", Offset = "0x2C7DD4C", VA = "0x2C7DD4C")]
	public IngameAvatarMaterialAnimComponent()
	{
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x2C7DE40", Offset = "0x2C7DE40", VA = "0x2C7DE40")]
	public void AddTargets(UIModelAvatarBase.EWardrobeType type, MaterialRef matRef)
	{
	}

	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x2C7DFCC", Offset = "0x2C7DFCC", VA = "0x2C7DFCC")]
	public void CleanAllAnim()
	{
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x2C7E1E4", Offset = "0x2C7E1E4", VA = "0x2C7E1E4")]
	public void CleanAnim(UIModelAvatarBase.EWardrobeType type)
	{
	}

	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x2C7E38C", Offset = "0x2C7E38C", VA = "0x2C7E38C")]
	public void ShowAnim(UIModelAvatarBase.EWardrobeType type)
	{
	}

	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x2C7E564", Offset = "0x2C7E564", VA = "0x2C7E564")]
	private void FindUMARenderer()
	{
	}

	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x2C7E720", Offset = "0x2C7E720", VA = "0x2C7E720")]
	private void AddTargetComponent(UIModelAvatarBase.EWardrobeType type, MaterialRef materialRef, Material[] mats)
	{
	}

	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x2C7EFE4", Offset = "0x2C7EFE4", VA = "0x2C7EFE4")]
	public void ShowAllAnim()
	{
	}

	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x2C7ECE4", Offset = "0x2C7ECE4", VA = "0x2C7ECE4")]
	private bool FindMatchedMaterial(Material[] mats, PropertyRecorder item, out Material mat, out int materialIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x2C7F2F4", Offset = "0x2C7F2F4", VA = "0x2C7F2F4")]
	public void UpdateEffectVisiblityMaterial(int type, bool vis, bool reverse)
	{
	}

	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x2C7F388", Offset = "0x2C7F388", VA = "0x2C7F388")]
	public void UpdateEffectVisibility(int type, bool vis = true, bool simpleAct = true, bool reverse = false)
	{
	}

	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x2C7F81C", Offset = "0x2C7F81C", VA = "0x2C7F81C")]
	public void UpdateEffectVisibility(bool vis = true)
	{
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x2C7FB54", Offset = "0x2C7FB54", VA = "0x2C7FB54")]
	public bool CheckTargetsExist(UIModelAvatarBase.EWardrobeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x2C7FC1C", Offset = "0x2C7FC1C", VA = "0x2C7FC1C")]
	public void RemoveTargets(UIModelAvatarBase.EWardrobeType type, bool resetToForward)
	{
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x2C7FCCC", Offset = "0x2C7FCCC", VA = "0x2C7FCCC")]
	public void Clear(UIModelAvatarBase.EWardrobeType type)
	{
	}

	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x2C7FDD0", Offset = "0x2C7FDD0", VA = "0x2C7FDD0")]
	public void AddHoldOnType(int type)
	{
	}

	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x2C7FE9C", Offset = "0x2C7FE9C", VA = "0x2C7FE9C")]
	public void RemoveHoldOnType(int type)
	{
	}
}
