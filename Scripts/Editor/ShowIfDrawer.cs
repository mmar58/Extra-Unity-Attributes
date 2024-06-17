namespace MMAR.Attributes {
    using UnityEditor;
    using UnityEngine;

    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ShowIfDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Get the ShowIf attribute data
            ShowIfAttribute showIfAttribute = (ShowIfAttribute)attribute;
            string conditionalFieldName = showIfAttribute.ConditionalFieldName;

            // Find the conditional field
            SerializedProperty conditionalField = property.serializedObject.FindProperty(conditionalFieldName);

            // Check if the conditional field exists and is a boolean
            if (conditionalField != null && conditionalField.propertyType == SerializedPropertyType.Boolean) {
                // Show the field only if the conditional field is true
                if (conditionalField.boolValue) {
                    EditorGUI.PropertyField(position, property, label, true);
                }
            }
            else {
                // Handle the case where the conditional field is missing or invalid
                EditorGUI.LabelField(position, label.text, "Error: Conditional field not found or not a boolean");
            }
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            ShowIfAttribute showIfAttribute = (ShowIfAttribute)attribute;
            string conditionalFieldName = showIfAttribute.ConditionalFieldName;
            SerializedProperty conditionalField = property.serializedObject.FindProperty(conditionalFieldName);

            if (conditionalField != null && conditionalField.propertyType == SerializedPropertyType.Boolean) {
                if (conditionalField.boolValue) {
                    if (property.propertyType == SerializedPropertyType.Vector3) {
                        return EditorGUIUtility.singleLineHeight * 2;
                    }

                    return EditorGUI.GetPropertyHeight(property, label, true);
                }
                else {
                    // Hide the field completely
                    return 0;
                }
            }

            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }

}
