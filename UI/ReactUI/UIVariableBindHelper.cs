using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CCA")]
public class UIVariableBindHelper
{
	[Token(Token = "0x2000CCB")]
	public struct VarBindData
	{
		[Token(Token = "0x40067E1")]
		[FieldOffset(Offset = "0x0")]
		public string m_varName;

		[Token(Token = "0x40067E2")]
		[FieldOffset(Offset = "0x4")]
		public PropertyInfo m_prop;

		[Token(Token = "0x40067E3")]
		[FieldOffset(Offset = "0x8")]
		public FieldInfo m_field;
	}

	[Token(Token = "0x2000CCC")]
	public struct EventBindData
	{
		[Token(Token = "0x40067E4")]
		[FieldOffset(Offset = "0x0")]
		public string m_eventName;

		[Token(Token = "0x40067E5")]
		[FieldOffset(Offset = "0x4")]
		public MethodInfo m_method;
	}

	[Token(Token = "0x2000CCD")]
	public struct GameObjectBindData
	{
		[Token(Token = "0x40067E6")]
		[FieldOffset(Offset = "0x0")]
		public string m_varName;

		[Token(Token = "0x40067E7")]
		[FieldOffset(Offset = "0x4")]
		public PropertyInfo m_prop;

		[Token(Token = "0x40067E8")]
		[FieldOffset(Offset = "0x8")]
		public FieldInfo m_field;
	}

	[Token(Token = "0x2000CCE")]
	public class AutoBindForClass
	{
		[Token(Token = "0x40067E9")]
		[FieldOffset(Offset = "0x8")]
		public List<VarBindData> m_bindVar;

		[Token(Token = "0x40067EA")]
		[FieldOffset(Offset = "0xC")]
		public List<EventBindData> m_bindEvent;

		[Token(Token = "0x40067EB")]
		[FieldOffset(Offset = "0x10")]
		public List<GameObjectBindData> m_bindGameObject;

		[Token(Token = "0x6006160")]
		[Address(RVA = "0x31622FC", Offset = "0x31622FC", VA = "0x31622FC")]
		public AutoBindForClass()
		{
		}
	}

	[Token(Token = "0x40067DD")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, AutoBindForClass> m_cacheBindProp;

	[Token(Token = "0x40067DE")]
	[FieldOffset(Offset = "0x4")]
	private static string prefix_var;

	[Token(Token = "0x40067DF")]
	[FieldOffset(Offset = "0x8")]
	private static string prefix_event;

	[Token(Token = "0x40067E0")]
	[FieldOffset(Offset = "0xC")]
	private static string prefix_gameobject;

	[Token(Token = "0x6006157")]
	[Address(RVA = "0x3160B90", Offset = "0x3160B90", VA = "0x3160B90")]
	public UIVariableBindHelper()
	{
	}

	[Token(Token = "0x6006158")]
	[Address(RVA = "0x3160B98", Offset = "0x3160B98", VA = "0x3160B98")]
	public static void AutoBind(object obj, GameObject view, [Optional] Type baseClass)
	{
	}

	[Token(Token = "0x6006159")]
	[Address(RVA = "0x3161254", Offset = "0x3161254", VA = "0x3161254")]
	private static void AutoBindGameObject(object targetObject, GameObject rootObj, List<GameObjectBindData> bind)
	{
	}

	[Token(Token = "0x600615A")]
	public static T GetCustomAttribute<T>(PropertyInfo prop) where T : class
	{
		return null;
	}

	[Token(Token = "0x600615B")]
	public static T GetCustomAttribute<T>(FieldInfo prop) where T : class
	{
		return null;
	}

	[Token(Token = "0x600615C")]
	public static T GetCustomAttribute<T>(MethodInfo prop) where T : class
	{
		return null;
	}

	[Token(Token = "0x600615D")]
	[Address(RVA = "0x3161754", Offset = "0x3161754", VA = "0x3161754")]
	private static void GenerateAutoBind(AutoBindForClass autoBind, Type t)
	{
	}

	[Token(Token = "0x600615E")]
	[Address(RVA = "0x316111C", Offset = "0x316111C", VA = "0x316111C")]
	private static AutoBindForClass GenerateAutoBind(Type t, [Optional] Type baseClass)
	{
		return null;
	}
}
