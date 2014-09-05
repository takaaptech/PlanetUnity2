

using UnityEngine;


//
// Autogenerated by gaxb ( https://github.com/SmallPlanet/gaxb )
//

using System;
using System.Xml;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;


public partial class PUNotification : PUNotificationBase {
	
	public PUNotification()
	{
	}
	
	
	public PUNotification(
			string name ) : this()
	{
		this.name = name;
		this.nameExists = true;
	}

	

}




public class PUNotificationBase : IPlanetUnity2 {


	private static Type planetOverride = Type.GetType("PlanetUnityOverride");
	private static MethodInfo processStringMethod = planetOverride.GetMethod("processString", BindingFlags.Public | BindingFlags.Static);


	public object parent;
	public string xmlns;


	// XML Attributes
	public string name;
	public bool nameExists;




	
	public void SetName(string v) { name = v; nameExists = true; } 


	public virtual void gaxb_unload()
	{

	}
	
	public void gaxb_addToParent()
	{
		if(parent != null)
		{
			FieldInfo parentField = parent.GetType().GetField("Notification");
			List<object> parentChildren = null;
			
			if(parentField != null)
			{
				parentField.SetValue(parent, this);
				
				parentField = parent.GetType().GetField("NotificationExists");
				parentField.SetValue(parent, true);
			}
			else
			{
				parentField = parent.GetType().GetField("Notifications");
				
				if(parentField != null)
				{
					parentChildren = (List<object>)(parentField.GetValue(parent));
				}
				else
				{
					parentField = parent.GetType().GetField("PlanetUnity2s");
					if(parentField != null)
					{
						parentChildren = (List<object>)(parentField.GetValue(parent));
					}
				}
				if(parentChildren == null)
				{
					FieldInfo childrenField = parent.GetType().GetField("children");
					if(childrenField != null)
					{
						parentChildren = (List<object>)childrenField.GetValue(parent);
					}
				}
				if(parentChildren != null)
				{
					parentChildren.Add(this);
				}
				
			}
		}
	}

	public virtual void gaxb_load(XmlReader reader, object _parent, Hashtable args)
	{

		if(reader == null && _parent == null)
			return;
		
		parent = _parent;
		
		if(this.GetType() == typeof( PUNotification ))
		{
			gaxb_addToParent();
		}
		
		xmlns = reader.GetAttribute("xmlns");
		

		string attr;
		attr = reader.GetAttribute("name");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { name = attr; nameExists = true; } 
		

	}
	
	
	
	
	
	
	
	public virtual void gaxb_appendXMLAttributes(StringBuilder sb)
	{

		if(nameExists) { sb.AppendFormat (" {0}=\"{1}\"", "name", name); }

	}
	
	public virtual void gaxb_appendXMLSequences(StringBuilder sb)
	{


	}
	
	public virtual void gaxb_appendXML(StringBuilder sb)
	{
		if(sb.Length == 0)
		{
			sb.AppendFormat ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		
		sb.AppendFormat ("<{0}", "Notification");
		
		if(xmlns != null)
		{
			sb.AppendFormat (" {0}=\"{1}\"", "xmlns", xmlns);
		}
		
		gaxb_appendXMLAttributes(sb);
		
		
		StringBuilder seq = new StringBuilder();
		seq.AppendFormat(" ");
		gaxb_appendXMLSequences(seq);
		
		if(seq.Length == 1)
		{
			sb.AppendFormat (" />");
		}
		else
		{
			sb.AppendFormat (">{0}</{1}>", seq.ToString(), "Notification");
		}
	}
}
