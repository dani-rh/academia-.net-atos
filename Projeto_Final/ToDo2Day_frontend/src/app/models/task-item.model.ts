export interface TaskItem {
  taskItemId: string;
  title: string;
  description: string;
  userId: string;
  tagId: string;
  isCompleted: boolean;
  createdAt: Date;
  updatedAt: Date;
}
