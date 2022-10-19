import numpy as np
import matplotlib.pyplot as plt


plt.style.use('dark_background')
# x range between 0~10, there is 100 elements in between
x = np.linspace(0,10,100)
fig = plt.figure()
plt.plot(x,np.sin(x),'-')
plt.plot(x,np.cos(x),'--')

#Save as .png file
# fig.savefig('my_figure.png')

# save filetype info
# print(fig.canvas.get_supported_filetypes())
# {
#     'eps': 'Encapsulated Postscript',
#     'jpg': 'Joint Photographic Experts Group',
#     'jpeg': 'Joint Photographic Experts Group',
#     'pdf': 'Portable Document Format',
#     'pgf': 'PGF code for LaTeX',
#     'png': 'Portable Network Graphics', 
#     'ps': 'Postscript', 
#     'raw': 'Raw RGBA bitmap', 
#     'rgba': 'Raw RGBA bitmap', 
#     'svg': 'Scalable Vector Graphics', 
#     'svgz': 'Scalable Vector Graphics', 
#     'tif': 'Tagged Image File Format', 
#     'tiff': 'Tagged Image File Format', 
#     'webp': 'WebP Image Format'
#     }

plt.show()
