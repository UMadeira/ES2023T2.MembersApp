using MembersApp.Data;
using MembersApp.Patterns;
using System;
using System.Runtime.InteropServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MembersApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnAddPerson(object sender, EventArgs e)
        {
            var dialog = new PromptForm();
            dialog.Title = "Create Person";
            dialog.Label = "Name:";
            dialog.Value = string.Empty;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var person = new Person() { Name = dialog.Value };
                AddMemberNode(peopleTreeView.Nodes, person);
            }
        }

        private void OnAddGroup(object sender, EventArgs e)
        {
            var dialog = new PromptForm();
            dialog.Title = "Create Group";
            dialog.Label = "Name:";
            dialog.Value = string.Empty;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var group = new Group() { Name = dialog.Value };
                AddMemberNode( groupsTreeView.Nodes, group );
            }
        }

        private void OnJoinGroup(object sender, EventArgs e)
        {
            var group = GetSemantic<Group>(groupsTreeView.SelectedNode);
            if (group == null) return;

            var person = GetSemantic<Person>(peopleTreeView.SelectedNode);
            if (person == null) return;

            group.Members.Add(person);

            AddMemberNode( groupsTreeView.SelectedNode.Nodes, person );
        }

        private void AddMemberNode( TreeNodeCollection nodes, Member member)
        {
            var node = nodes.Add( member.Name );
            node.ImageKey = node.SelectedImageKey = member.GetType().Name;
            node.Tag = member.Subscribe((s, a) => node.Text = member.Name);
        }

        private void OnLeaveGroup(object sender, EventArgs e)
        {
            var person = GetSemantic<Person>(groupsTreeView.SelectedNode);
            if (person == null) return;

            var group = GetSemantic<Group>(groupsTreeView.SelectedNode?.Parent);
            if (group == null) return;

            group.Members.Remove(person);

            var observer = groupsTreeView.SelectedNode?.Tag as Observer;
            observer?.Unsubscribe();

            groupsTreeView.SelectedNode?.Remove();
        }

        private void OnEdit(object sender, EventArgs e)
        {
            var person = GetSemantic<Person>(peopleTreeView.SelectedNode);
            if (person == null) return;

            var dialog = new PromptForm
            {
                Title = "Change Name",
                Label = "Name:",
                Value = person.Name
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                person.Name = dialog.Value;
            }
        }

        //private StatusBarAdapter LabelAdapter { get; set; }

        private void OnPersonSelected(object sender, TreeViewEventArgs e)
        {
            var observer = personStatusLabel.Tag as Observer;
            observer?.Unsubscribe();

            var person = GetSemantic<Person>( peopleTreeView.SelectedNode );
            if (person == null) return;

            personStatusLabel.Text = person.Name;
            personStatusLabel.Tag = person.Subscribe((s, a) => personStatusLabel.Text = person.Name);
        }

        private static T GetSemantic<T>(TreeNode? node)
        {
            var observer = node?.Tag as Observer;
            return (T)observer?.Observable;
        }
    }
}